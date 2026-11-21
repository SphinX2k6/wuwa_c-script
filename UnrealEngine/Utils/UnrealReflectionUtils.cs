using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x0200089F RID: 2207
	public class UnrealReflectionUtils
	{
		// Token: 0x0600BE19 RID: 48665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void CallUFunctionImpl(IntPtr NativeObjectPtr, IntPtr NativeUFunctionPtr, void* ParamsBuffer);

		// Token: 0x0600BE1A RID: 48666 RVA: 0x0012FA91 File Offset: 0x0012DC91
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void CallUFunction(IntPtr NativeObjectPtr, IntPtr NativeUFunctionPtr, void* ParamsBuffer)
		{
			UnrealReflectionUtils.CallUFunctionImpl(NativeObjectPtr, NativeUFunctionPtr, ParamsBuffer);
		}

		// Token: 0x0600BE1B RID: 48667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void CallVirtualUFunctionImpl(IntPtr NativeObjectPtr, IntPtr NativeUFunctionPtr, void* ParamsBuffer);

		// Token: 0x0600BE1C RID: 48668 RVA: 0x0012FA9B File Offset: 0x0012DC9B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void CallVirtualUFunction(IntPtr NativeObjectPtr, IntPtr NativeUFunctionPtr, void* ParamsBuffer)
		{
			UnrealReflectionUtils.CallVirtualUFunctionImpl(NativeObjectPtr, NativeUFunctionPtr, ParamsBuffer);
		}

		// Token: 0x0600BE1D RID: 48669
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetUFunctionPtr(IntPtr NativeObjectPtr, FName FunctionName);

		// Token: 0x0600BE1E RID: 48670 RVA: 0x0012FAA5 File Offset: 0x0012DCA5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr GetUFunctionPtrChecked(IntPtr NativeObjectPtr, FName FunctionName)
		{
			IntPtr ufunctionPtr = UnrealReflectionUtils.GetUFunctionPtr(NativeObjectPtr, FunctionName);
			if (ufunctionPtr == 0)
			{
				throw new UFunctionPtrIsNullException();
			}
			return ufunctionPtr;
		}

		// Token: 0x0600BE1F RID: 48671
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetUFunctionPtrAndSize(IntPtr NativeObjectPtr, FName FunctionName, out int PropertySize);

		// Token: 0x0600BE20 RID: 48672 RVA: 0x0012FAB7 File Offset: 0x0012DCB7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr GetUFunctionPtrAndSizeChecked(IntPtr NativeObjectPtr, FName FunctionName, out int PropertySize)
		{
			IntPtr ufunctionPtrAndSize = UnrealReflectionUtils.GetUFunctionPtrAndSize(NativeObjectPtr, FunctionName, out PropertySize);
			if (ufunctionPtrAndSize == 0)
			{
				throw new UFunctionPtrIsNullException();
			}
			return ufunctionPtrAndSize;
		}

		// Token: 0x0600BE21 RID: 48673
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetUFunctionPtrAndSizePack(IntPtr NativeObjectPtr, FName FunctionName, out int PropertySize, out int PropertyPackMinusOne);

		// Token: 0x0600BE22 RID: 48674 RVA: 0x0012FACA File Offset: 0x0012DCCA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr GetUFunctionPtrAndSizePackChecked(IntPtr NativeObjectPtr, FName FunctionName, out int PropertySize, out int PropertyPackMinusOne)
		{
			IntPtr ufunctionPtrAndSizePack = UnrealReflectionUtils.GetUFunctionPtrAndSizePack(NativeObjectPtr, FunctionName, out PropertySize, out PropertyPackMinusOne);
			if (ufunctionPtrAndSizePack == 0)
			{
				throw new UFunctionPtrIsNullException();
			}
			return ufunctionPtrAndSizePack;
		}

		// Token: 0x0600BE23 RID: 48675
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetUFunctionPtrAndSizeAndNeedVirtual(IntPtr NativeObjectPtr, FName FunctionName, UClassStackOnlyPtr CompareClass, out int PropertySize, out bool NeedVirtual);

		// Token: 0x0600BE24 RID: 48676 RVA: 0x0012FAE0 File Offset: 0x0012DCE0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GetUFunctionPtrAndSizeAndNeedVirtualChecked(IntPtr NativeObjectPtr, FName FunctionName, UClassStackOnlyPtr CompareClass, out IntPtr FunctionPtr, out int PropertySize)
		{
			bool result;
			FunctionPtr = UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtual(NativeObjectPtr, FunctionName, CompareClass, out PropertySize, out result);
			if (FunctionPtr == 0)
			{
				throw new UFunctionPtrIsNullException();
			}
			return result;
		}

		// Token: 0x0600BE25 RID: 48677
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void CallUFunction_Fast(IntPtr NativeObjectPtr, IntPtr NativeUFunctionPtr, void* ParamsBuffer);

		// Token: 0x0600BE26 RID: 48678
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocNativeStruct(UScriptStructStackOnlyPtr NativeUStructPtr);

		// Token: 0x0600BE27 RID: 48679
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyAndDeallocNativeStruct(UScriptStructStackOnlyPtr NativeUStructPtr, IntPtr Dest, int ArrayDim = 1);

		// Token: 0x0600BE28 RID: 48680
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void InitializeStruct(UScriptStructStackOnlyPtr NativeUStructPtr, void* Dest, int ArrayDim = 1);

		// Token: 0x0600BE29 RID: 48681
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void DestroyStruct(UScriptStructStackOnlyPtr NativeUStructPtr, void* Dest, int ArrayDim = 1);

		// Token: 0x0600BE2A RID: 48682
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyNativeStruct(UScriptStructStackOnlyPtr NativeUStructPtr, IntPtr Dest, IntPtr Src, int ArrayDim = 1, bool bShouldInitialize = false);

		// Token: 0x0600BE2B RID: 48683
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CompareNativeStruct(UScriptStructStackOnlyPtr NativeUStructPtr, IntPtr Dest, IntPtr Src);

		// Token: 0x0600BE2C RID: 48684
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FindNativeStructIndexInArray(UScriptStructStackOnlyPtr NativeStructPtr, IntPtr ArrayPtr, IntPtr StructPtr, int ArrayDim);

		// Token: 0x0600BE2D RID: 48685
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetUScriptStructProps(UScriptStructStackOnlyPtr NativeStructPtr, out int size, out int minAlignment, out int propertiesSize);

		// Token: 0x0600BE2E RID: 48686 RVA: 0x0012FB08 File Offset: 0x0012DD08
		public static int GetUScriptStructSize(UScriptStructStackOnlyPtr staticStruct)
		{
			int result;
			int num;
			int num2;
			UnrealReflectionUtils.GetUScriptStructProps(staticStruct, out result, out num, out num2);
			return result;
		}

		// Token: 0x0600BE2F RID: 48687 RVA: 0x0012FB24 File Offset: 0x0012DD24
		public static int GetUScriptStructMinAlignment(UScriptStructStackOnlyPtr staticStruct)
		{
			int num;
			int result;
			int num2;
			UnrealReflectionUtils.GetUScriptStructProps(staticStruct, out num, out result, out num2);
			return result;
		}
	}
}
