using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C70 RID: 7280
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRopeEffect.ArcRopeDataAsset")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UArcRopeDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C3D8 RID: 115672 RVA: 0x0029A17E File Offset: 0x0029837E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UArcRopeDataAsset._ClassPtr;
		}

		// Token: 0x0601C3D9 RID: 115673 RVA: 0x0029A18C File Offset: 0x0029838C
		public UArcRopeDataAsset() : this(BuiltinUtils.AllocNativeUObject(UArcRopeDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C3DA RID: 115674 RVA: 0x0029A1B4 File Offset: 0x002983B4
		public UArcRopeDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UArcRopeDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700721E RID: 29214
		// (get) Token: 0x0601C3DB RID: 115675 RVA: 0x0029A1E7 File Offset: 0x002983E7
		// (set) Token: 0x0601C3DC RID: 115676 RVA: 0x0029A1FC File Offset: 0x002983FC
		public TSoftObjectPtr<UNiagaraSystem> NiagaraEffect
		{
			get
			{
				return new TSoftObjectPtr<UNiagaraSystem>(base.NativePtr + (IntPtr)UArcRopeDataAsset.__PropertyOffset_NiagaraEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UArcRopeDataAsset.__PropertyOffset_NiagaraEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700721F RID: 29215
		// (get) Token: 0x0601C3DD RID: 115677 RVA: 0x0029A224 File Offset: 0x00298424
		// (set) Token: 0x0601C3DE RID: 115678 RVA: 0x0029A25D File Offset: 0x0029845D
		public FArcRopeParams Params
		{
			get
			{
				base.FastCheckIsValid();
				FArcRopeParams result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new FArcRopeParams(base.NativePtr + (IntPtr)UArcRopeDataAsset.__PropertyOffset_Params, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FArcRopeParams.StaticStruct(), base.NativePtr + (IntPtr)UArcRopeDataAsset.__PropertyOffset_Params, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601C3DF RID: 115679 RVA: 0x0029A27E File Offset: 0x0029847E
		static UArcRopeDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.ArcRopeDataAsset");
		}

		// Token: 0x0601C3E0 RID: 115680 RVA: 0x0029A28C File Offset: 0x0029848C
		protected UArcRopeDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F2F7 RID: 62199
		public new const string __ObjectPath = "/Script/KuroRopeEffect.ArcRopeDataAsset";

		// Token: 0x0400F2F8 RID: 62200
		private static IntPtr _ClassPtr;

		// Token: 0x0400F2F9 RID: 62201
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F2FA RID: 62202
		internal static int __PropertyOffset_NiagaraEffect;

		// Token: 0x0400F2FB RID: 62203
		internal static int __PropertyOffset_Params;

		// Token: 0x0400F2FC RID: 62204
		[Nullable(2)]
		private FArcRopeParams _Params;
	}
}
