using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x02002AF0 RID: 10992
	public class UnrealReflectionUtils
	{
		// Token: 0x06028464 RID: 164964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void CallUFunction(IntPtr NativeObjectPtr, IntPtr NativeUFunctionPtr, void* ParamsBuffer);

		// Token: 0x06028465 RID: 164965 RVA: 0x003D4781 File Offset: 0x003D2981
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void CallUFunction(IntPtr NativeObjectPtr, IntPtr NativeUFunctionPtr, void* ParamsBuffer, int _ = 0)
		{
			SharpherealAssert.FastNativePtrAssert(NativeUFunctionPtr);
			UnrealReflectionUtils.CallUFunction(NativeObjectPtr, NativeUFunctionPtr, ParamsBuffer);
		}

		// Token: 0x06028466 RID: 164966
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void CallVirtualUFunction(IntPtr NativeObjectPtr, IntPtr NativeUFunctionPtr, void* ParamsBuffer);

		// Token: 0x06028467 RID: 164967 RVA: 0x003D4791 File Offset: 0x003D2991
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void CallVirtualUFunction(IntPtr NativeObjectPtr, IntPtr NativeUFunctionPtr, void* ParamsBuffer, int _ = 0)
		{
			if (NativeUFunctionPtr == 0)
			{
				throw new UFunctionPtrIsNullException();
			}
			UnrealReflectionUtils.CallVirtualUFunction(NativeObjectPtr, NativeUFunctionPtr, ParamsBuffer);
		}

		// Token: 0x06028468 RID: 164968
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetUFunctionPtrChecked(IntPtr NativeObjectPtr, FName FunctionName);

		// Token: 0x06028469 RID: 164969
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetUFunctionPtrAndSizeChecked(IntPtr NativeObjectPtr, FName FunctionName, out int PropertySize);

		// Token: 0x0602846A RID: 164970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetUFunctionPtrAndSizePack(IntPtr NativeObjectPtr, FName FunctionName, out int PropertySize, out int PropertyPackMinusOne);

		// Token: 0x0602846B RID: 164971 RVA: 0x003D47A4 File Offset: 0x003D29A4
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

		// Token: 0x0602846C RID: 164972
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void CallUFunction_Fast(IntPtr NativeObjectPtr, IntPtr NativeUFunctionPtr, void* ParamsBuffer);

		// Token: 0x0602846D RID: 164973
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocNativeStruct(UScriptStructStackOnlyPtr NativeUStructPtr);

		// Token: 0x0602846E RID: 164974
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyAndDeallocNativeStruct(UScriptStructStackOnlyPtr NativeUStructPtr, IntPtr Dest, int ArrayDim = 1);

		// Token: 0x0602846F RID: 164975
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void InitializeStruct(UScriptStructStackOnlyPtr NativeUStructPtr, void* Dest, int ArrayDim = 1);

		// Token: 0x06028470 RID: 164976
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void DestroyStruct(UScriptStructStackOnlyPtr NativeUStructPtr, void* Dest, int ArrayDim = 1);

		// Token: 0x06028471 RID: 164977
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CopyNativeStruct(UScriptStructStackOnlyPtr NativeUStructPtr, IntPtr Dest, IntPtr Src, int ArrayDim = 1, bool bShouldInitialize = false);

		// Token: 0x06028472 RID: 164978
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CompareNativeStruct(UScriptStructStackOnlyPtr NativeUStructPtr, IntPtr Dest, IntPtr Src);

		// Token: 0x06028473 RID: 164979
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FindNativeStructIndexInArray(UScriptStructStackOnlyPtr NativeStructPtr, IntPtr ArrayPtr, IntPtr StructPtr, int ArrayDim);

		// Token: 0x06028474 RID: 164980
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetUScriptStructProps(UScriptStructStackOnlyPtr NativeStructPtr, out int size, out int minAlignment, out int propertiesSize);

		// Token: 0x06028475 RID: 164981 RVA: 0x003D47B8 File Offset: 0x003D29B8
		public static int GetUScriptStructSize(UScriptStructStackOnlyPtr staticStruct)
		{
			int result;
			int num;
			int num2;
			UnrealReflectionUtils.GetUScriptStructProps(staticStruct, out result, out num, out num2);
			return result;
		}

		// Token: 0x06028476 RID: 164982 RVA: 0x003D47D4 File Offset: 0x003D29D4
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
