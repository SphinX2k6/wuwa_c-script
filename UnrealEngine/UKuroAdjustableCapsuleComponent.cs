using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002ED RID: 749
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAdjustableCapsuleComponent")]
	[UnrealStructLayout(1664, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class UKuroAdjustableCapsuleComponent : UCapsuleComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004FD3 RID: 20435 RVA: 0x0006FB42 File Offset: 0x0006DD42
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAdjustableCapsuleComponent._ClassPtr;
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x0006FB50 File Offset: 0x0006DD50
		public UKuroAdjustableCapsuleComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroAdjustableCapsuleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x0006FB78 File Offset: 0x0006DD78
		public UKuroAdjustableCapsuleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAdjustableCapsuleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x0006FBAC File Offset: 0x0006DDAC
		// (set) Token: 0x06004FD7 RID: 20439 RVA: 0x0006FBE5 File Offset: 0x0006DDE5
		public TArray<FName> BindSocketNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BindSocketNames) == null)
				{
					result = (this._BindSocketNames = new TArray<FName>(base.NativePtr + (IntPtr)UKuroAdjustableCapsuleComponent.__PropertyOffset_BindSocketNames, this));
				}
				return result;
			}
			set
			{
				this.BindSocketNames.CopyAssign(value);
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x0006FBF3 File Offset: 0x0006DDF3
		// (set) Token: 0x06004FD9 RID: 20441 RVA: 0x0006FC03 File Offset: 0x0006DE03
		public unsafe float AddRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAdjustableCapsuleComponent.__PropertyOffset_AddRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAdjustableCapsuleComponent.__PropertyOffset_AddRadius) = value;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06004FDA RID: 20442 RVA: 0x0006FC14 File Offset: 0x0006DE14
		// (set) Token: 0x06004FDB RID: 20443 RVA: 0x0006FC24 File Offset: 0x0006DE24
		public unsafe float MinRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAdjustableCapsuleComponent.__PropertyOffset_MinRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAdjustableCapsuleComponent.__PropertyOffset_MinRadius) = value;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06004FDC RID: 20444 RVA: 0x0006FC35 File Offset: 0x0006DE35
		// (set) Token: 0x06004FDD RID: 20445 RVA: 0x0006FC45 File Offset: 0x0006DE45
		public unsafe float MaxRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAdjustableCapsuleComponent.__PropertyOffset_MaxRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAdjustableCapsuleComponent.__PropertyOffset_MaxRadius) = value;
			}
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x0006FC56 File Offset: 0x0006DE56
		static UKuroAdjustableCapsuleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAdjustableCapsuleComponent");
		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x0006FC64 File Offset: 0x0006DE64
		protected UKuroAdjustableCapsuleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002079 RID: 8313
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAdjustableCapsuleComponent";

		// Token: 0x0400207A RID: 8314
		private static IntPtr _ClassPtr;

		// Token: 0x0400207B RID: 8315
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400207C RID: 8316
		internal static int __PropertyOffset_BindSocketNames;

		// Token: 0x0400207D RID: 8317
		[Nullable(2)]
		private TArray<FName> _BindSocketNames;

		// Token: 0x0400207E RID: 8318
		internal static int __PropertyOffset_AddRadius;

		// Token: 0x0400207F RID: 8319
		internal static int __PropertyOffset_MinRadius;

		// Token: 0x04002080 RID: 8320
		internal static int __PropertyOffset_MaxRadius;
	}
}
