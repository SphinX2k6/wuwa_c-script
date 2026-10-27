using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000504 RID: 1284
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.FKControlRig")]
	[UnrealStructLayout(2088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2088)]
	public class UFKControlRig : UControlRig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600431B RID: 17179 RVA: 0x00064212 File Offset: 0x00062412
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFKControlRig._ClassPtr;
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x00064220 File Offset: 0x00062420
		public UFKControlRig() : this(BuiltinUtils.AllocNativeUObject(UFKControlRig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x00064248 File Offset: 0x00062448
		public UFKControlRig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFKControlRig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x0006427C File Offset: 0x0006247C
		// (set) Token: 0x0600431F RID: 17183 RVA: 0x000642B5 File Offset: 0x000624B5
		public TArray<bool> IsControlActive
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._IsControlActive) == null)
				{
					result = (this._IsControlActive = new TArray<bool>(base.NativePtr + (IntPtr)UFKControlRig.__PropertyOffset_IsControlActive, this));
				}
				return result;
			}
			set
			{
				this.IsControlActive.CopyAssign(value);
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x000642C3 File Offset: 0x000624C3
		// (set) Token: 0x06004321 RID: 17185 RVA: 0x000642D3 File Offset: 0x000624D3
		public unsafe EControlRigFKRigExecuteMode ApplyMode
		{
			get
			{
				return (EControlRigFKRigExecuteMode)(*(base.NativePtr + (IntPtr)UFKControlRig.__PropertyOffset_ApplyMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFKControlRig.__PropertyOffset_ApplyMode) = (byte)value;
			}
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x000642E4 File Offset: 0x000624E4
		static UFKControlRig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.FKControlRig");
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x000642F2 File Offset: 0x000624F2
		protected UFKControlRig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040020BA RID: 8378
		public new const string __ObjectPath = "/Script/ControlRig.FKControlRig";

		// Token: 0x040020BB RID: 8379
		private static IntPtr _ClassPtr;

		// Token: 0x040020BC RID: 8380
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040020BD RID: 8381
		internal static int __PropertyOffset_IsControlActive;

		// Token: 0x040020BE RID: 8382
		[Nullable(2)]
		private TArray<bool> _IsControlActive;

		// Token: 0x040020BF RID: 8383
		internal static int __PropertyOffset_ApplyMode;
	}
}
