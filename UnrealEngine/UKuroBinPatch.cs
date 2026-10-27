using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001981 RID: 6529
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroBinPatch")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroBinPatch : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601840E RID: 99342 RVA: 0x0023C4F5 File Offset: 0x0023A6F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBinPatch._ClassPtr;
		}

		// Token: 0x0601840F RID: 99343 RVA: 0x0023C504 File Offset: 0x0023A704
		public UKuroBinPatch() : this(BuiltinUtils.AllocNativeUObject(UKuroBinPatch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018410 RID: 99344 RVA: 0x0023C52C File Offset: 0x0023A72C
		public UKuroBinPatch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBinPatch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006102 RID: 24834
		// (get) Token: 0x06018411 RID: 99345 RVA: 0x0023C560 File Offset: 0x0023A760
		// (set) Token: 0x06018412 RID: 99346 RVA: 0x0023C599 File Offset: 0x0023A799
		public FKuroBinPatchProgress ProgressDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBinPatchProgress result;
				if ((result = this._ProgressDelegate) == null)
				{
					result = (this._ProgressDelegate = new FKuroBinPatchProgress(base.NativePtr + (IntPtr)UKuroBinPatch.__PropertyOffset_ProgressDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroBinPatch.__PropertyOffset_ProgressDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006103 RID: 24835
		// (get) Token: 0x06018413 RID: 99347 RVA: 0x0023C5BC File Offset: 0x0023A7BC
		// (set) Token: 0x06018414 RID: 99348 RVA: 0x0023C5F5 File Offset: 0x0023A7F5
		public FKuroBinPatchComplete CompleteDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBinPatchComplete result;
				if ((result = this._CompleteDelegate) == null)
				{
					result = (this._CompleteDelegate = new FKuroBinPatchComplete(base.NativePtr + (IntPtr)UKuroBinPatch.__PropertyOffset_CompleteDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroBinPatch.__PropertyOffset_CompleteDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06018415 RID: 99349 RVA: 0x0023C618 File Offset: 0x0023A818
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void BeginPatch(string Diff, string OldDir, string NewDir)
		{
			UKuroBinPatch.__BeginPatch_FunctionParams* ptr = stackalloc UKuroBinPatch.__BeginPatch_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroBinPatch.__BeginPatch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBinPatch.__BeginPatch_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Diff), Diff);
			FString.CopyFrom((void*)(&ptr->OldDir), OldDir);
			FString.CopyFrom((void*)(&ptr->NewDir), NewDir);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroBinPatch.__BeginPatch_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroBinPatch.__BeginPatch_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018416 RID: 99350 RVA: 0x0023C690 File Offset: 0x0023A890
		static UKuroBinPatch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.KuroBinPatch");
		}

		// Token: 0x06018417 RID: 99351 RVA: 0x0023C69E File Offset: 0x0023A89E
		protected UKuroBinPatch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D22A RID: 53802
		public new const string __ObjectPath = "/Script/KuroHotPatch.KuroBinPatch";

		// Token: 0x0400D22B RID: 53803
		private static IntPtr _ClassPtr;

		// Token: 0x0400D22C RID: 53804
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D22D RID: 53805
		internal static int __PropertyOffset_ProgressDelegate;

		// Token: 0x0400D22E RID: 53806
		[Nullable(2)]
		private FKuroBinPatchProgress _ProgressDelegate;

		// Token: 0x0400D22F RID: 53807
		internal static int __PropertyOffset_CompleteDelegate;

		// Token: 0x0400D230 RID: 53808
		[Nullable(2)]
		private FKuroBinPatchComplete _CompleteDelegate;

		// Token: 0x0400D231 RID: 53809
		private static IntPtr __BeginPatch_NativeFunctionPtr;

		// Token: 0x02003078 RID: 12408
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __BeginPatch_FunctionParams
		{
			// Token: 0x04016D50 RID: 93520
			[FieldOffset(0)]
			public FString Diff;

			// Token: 0x04016D51 RID: 93521
			[FieldOffset(16)]
			public FString OldDir;

			// Token: 0x04016D52 RID: 93522
			[FieldOffset(32)]
			public FString NewDir;
		}
	}
}
