using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025BA RID: 9658
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraMeshMaterialOverride")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FNiagaraMeshMaterialOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023E43 RID: 147011 RVA: 0x0035124A File Offset: 0x0034F44A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraMeshMaterialOverride._ScriptStructPtr != 0) ? FNiagaraMeshMaterialOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraMeshMaterialOverride", ref FNiagaraMeshMaterialOverride._ScriptStructPtr);
		}

		// Token: 0x17008A00 RID: 35328
		// (get) Token: 0x06023E44 RID: 147012 RVA: 0x0035126E File Offset: 0x0034F46E
		// (set) Token: 0x06023E45 RID: 147013 RVA: 0x00351282 File Offset: 0x0034F482
		[Nullable(2)]
		public unsafe UMaterialInterface ExplicitMat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraMeshMaterialOverride.__PropertyOffset_ExplicitMat);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraMeshMaterialOverride.__PropertyOffset_ExplicitMat, value);
			}
		}

		// Token: 0x17008A01 RID: 35329
		// (get) Token: 0x06023E46 RID: 147014 RVA: 0x00351298 File Offset: 0x0034F498
		// (set) Token: 0x06023E47 RID: 147015 RVA: 0x003512DB File Offset: 0x0034F4DB
		public FNiagaraUserParameterBinding UserParamBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserParameterBinding result;
				if ((result = this._UserParamBinding) == null)
				{
					result = (this._UserParamBinding = new FNiagaraUserParameterBinding(base.NativePtr + (IntPtr)FNiagaraMeshMaterialOverride.__PropertyOffset_UserParamBinding, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserParameterBinding.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraMeshMaterialOverride.__PropertyOffset_UserParamBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023E48 RID: 147016 RVA: 0x003512FC File Offset: 0x0034F4FC
		public FNiagaraMeshMaterialOverride()
		{
		}

		// Token: 0x06023E49 RID: 147017 RVA: 0x00351304 File Offset: 0x0034F504
		public FNiagaraMeshMaterialOverride(UMaterialInterface ExplicitMat, FNiagaraUserParameterBinding UserParamBinding)
		{
			this.ExplicitMat = ExplicitMat;
			this.UserParamBinding = UserParamBinding;
		}

		// Token: 0x06023E4A RID: 147018 RVA: 0x0035131A File Offset: 0x0034F51A
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraMeshMaterialOverride.StaticStruct();
		}

		// Token: 0x06023E4B RID: 147019 RVA: 0x00351326 File Offset: 0x0034F526
		[NullableContext(2)]
		public FNiagaraMeshMaterialOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023E4C RID: 147020 RVA: 0x00351330 File Offset: 0x0034F530
		public FNiagaraMeshMaterialOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023E4D RID: 147021 RVA: 0x0035133B File Offset: 0x0034F53B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraMeshMaterialOverride(Pointer, false, true);
		}

		// Token: 0x06023E4E RID: 147022 RVA: 0x00351345 File Offset: 0x0034F545
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraMeshMaterialOverride(Pointer, MemoryOwner);
		}

		// Token: 0x040133E4 RID: 78820
		public const string __ObjectPath = "/Script/Niagara.NiagaraMeshMaterialOverride";

		// Token: 0x040133E5 RID: 78821
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040133E6 RID: 78822
		internal static int __PropertyOffset_ExplicitMat;

		// Token: 0x040133E7 RID: 78823
		internal static int __PropertyOffset_UserParamBinding;

		// Token: 0x040133E8 RID: 78824
		[Nullable(2)]
		private FNiagaraUserParameterBinding _UserParamBinding;
	}
}
