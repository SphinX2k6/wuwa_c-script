using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200043D RID: 1085
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroBinPatch")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroBinPatch : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060068FC RID: 26876 RVA: 0x00099462 File Offset: 0x00097662
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBinPatch._ClassPtr;
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x00099470 File Offset: 0x00097670
		public UKuroBinPatch() : this(BuiltinUtils.AllocNativeUObject(UKuroBinPatch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x00099498 File Offset: 0x00097698
		public UKuroBinPatch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBinPatch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060068FF RID: 26879 RVA: 0x000994CC File Offset: 0x000976CC
		// (set) Token: 0x06006900 RID: 26880 RVA: 0x00099505 File Offset: 0x00097705
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

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06006901 RID: 26881 RVA: 0x00099528 File Offset: 0x00097728
		// (set) Token: 0x06006902 RID: 26882 RVA: 0x00099561 File Offset: 0x00097761
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

		// Token: 0x06006903 RID: 26883 RVA: 0x00099584 File Offset: 0x00097784
		[SkipLocalsInit]
		public unsafe void BeginPatch(string Diff, string OldDir, string NewDir)
		{
			UKuroBinPatch.__BeginPatch_FunctionParams* ptr = stackalloc UKuroBinPatch.__BeginPatch_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroBinPatch.__BeginPatch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBinPatch.__BeginPatch_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Diff), Diff);
			FString.CopyFrom((void*)(&ptr->OldDir), OldDir);
			FString.CopyFrom((void*)(&ptr->NewDir), NewDir);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroBinPatch.__BeginPatch_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroBinPatch.__BeginPatch_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006904 RID: 26884 RVA: 0x000995FB File Offset: 0x000977FB
		static UKuroBinPatch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.KuroBinPatch");
		}

		// Token: 0x06006905 RID: 26885 RVA: 0x00099609 File Offset: 0x00097809
		protected UKuroBinPatch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002CBE RID: 11454
		public new const string __ObjectPath = "/Script/KuroHotPatch.KuroBinPatch";

		// Token: 0x04002CBF RID: 11455
		private static IntPtr _ClassPtr;

		// Token: 0x04002CC0 RID: 11456
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002CC1 RID: 11457
		internal static int __PropertyOffset_ProgressDelegate;

		// Token: 0x04002CC2 RID: 11458
		[Nullable(2)]
		private FKuroBinPatchProgress _ProgressDelegate;

		// Token: 0x04002CC3 RID: 11459
		internal static int __PropertyOffset_CompleteDelegate;

		// Token: 0x04002CC4 RID: 11460
		[Nullable(2)]
		private FKuroBinPatchComplete _CompleteDelegate;

		// Token: 0x04002CC5 RID: 11461
		private static IntPtr __BeginPatch_NativeFunctionPtr;

		// Token: 0x02000B5E RID: 2910
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __BeginPatch_FunctionParams
		{
			// Token: 0x04005C73 RID: 23667
			[FieldOffset(0)]
			public FString Diff;

			// Token: 0x04005C74 RID: 23668
			[FieldOffset(16)]
			public FString OldDir;

			// Token: 0x04005C75 RID: 23669
			[FieldOffset(32)]
			public FString NewDir;
		}
	}
}
