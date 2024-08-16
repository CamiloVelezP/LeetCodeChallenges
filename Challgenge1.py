class Solution(object):
    def mergeArrays(self, nums1, nums2):
        dict1 = {item[0]: item[1] for item in nums1 }
        for item in nums2:
            if item[0] in dict1:
                dict1[item[0]] += item[1]
            else:
                dict1[item[0]] = item[1]
        return sorted(dict1.items())