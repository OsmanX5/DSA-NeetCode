class Solution {
        public int trap(int[] height) {
    int left = 0, right = height.length - 1;
    int leftMax = 0, rightMax = 0;
    int water = 0;

    while (left < right) {
        if (height[left] < height[right]) {
            // Left bar is the limiting side
            if (height[left] >= leftMax) {
                leftMax = height[left];          // update wall
            } else {
                water += leftMax - height[left]; // trap water
            }
            left++;
        } else {
            // Right bar is the limiting side
            if (height[right] >= rightMax) {
                rightMax = height[right];
            } else {
                water += rightMax - height[right];
            }
            right--;
        }
    }
    return water;
}
}
