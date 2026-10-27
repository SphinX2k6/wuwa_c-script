using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001652 RID: 5714
	[UnrealObjectPath("/Script/KuroAnim.KuroAdjustableCapsuleComponent")]
	[UnrealStructLayout(1664, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class UKuroAdjustableCapsuleComponent : UCapsuleComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014913 RID: 84243 RVA: 0x001E4006 File Offset: 0x001E2206
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAdjustableCapsuleComponent._ClassPtr;
		}

		// Token: 0x06014914 RID: 84244 RVA: 0x001E4014 File Offset: 0x001E2214
		public UKuroAdjustableCapsuleComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroAdjustableCapsuleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014915 RID: 84245 RVA: 0x001E403C File Offset: 0x001E223C
		[NullableContext(1)]
		public UKuroAdjustableCapsuleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAdjustableCapsuleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170050F9 RID: 20729
		// (get) Token: 0x06014916 RID: 84246 RVA: 0x001E4070 File Offset: 0x001E2270
		// (set) Token: 0x06014917 RID: 84247 RVA: 0x001E40A9 File Offset: 0x001E22A9
		[Nullable(1)]
		public TArray<FName> BindSocketNames
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.BindSocketNames.CopyAssign(value);
			}
		}

		// Token: 0x170050FA RID: 20730
		// (get) Token: 0x06014918 RID: 84248 RVA: 0x001E40B7 File Offset: 0x001E22B7
		// (set) Token: 0x06014919 RID: 84249 RVA: 0x001E40C7 File Offset: 0x001E22C7
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

		// Token: 0x170050FB RID: 20731
		// (get) Token: 0x0601491A RID: 84250 RVA: 0x001E40D8 File Offset: 0x001E22D8
		// (set) Token: 0x0601491B RID: 84251 RVA: 0x001E40E8 File Offset: 0x001E22E8
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

		// Token: 0x170050FC RID: 20732
		// (get) Token: 0x0601491C RID: 84252 RVA: 0x001E40F9 File Offset: 0x001E22F9
		// (set) Token: 0x0601491D RID: 84253 RVA: 0x001E4109 File Offset: 0x001E2309
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

		// Token: 0x170050FD RID: 20733
		// (get) Token: 0x0601491E RID: 84254 RVA: 0x001E411A File Offset: 0x001E231A
		// (set) Token: 0x0601491F RID: 84255 RVA: 0x001E412E File Offset: 0x001E232E
		public unsafe TEnumAsByte<EAdjustCapsuleType> AdjustCapsuleType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAdjustableCapsuleComponent.__PropertyOffset_AdjustCapsuleType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAdjustableCapsuleComponent.__PropertyOffset_AdjustCapsuleType) = value;
			}
		}

		// Token: 0x06014920 RID: 84256 RVA: 0x001E4143 File Offset: 0x001E2343
		static UKuroAdjustableCapsuleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAdjustableCapsuleComponent");
		}

		// Token: 0x06014921 RID: 84257 RVA: 0x001E4151 File Offset: 0x001E2351
		protected UKuroAdjustableCapsuleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B3AB RID: 45995
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAdjustableCapsuleComponent";

		// Token: 0x0400B3AC RID: 45996
		private static IntPtr _ClassPtr;

		// Token: 0x0400B3AD RID: 45997
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B3AE RID: 45998
		internal static int __PropertyOffset_BindSocketNames;

		// Token: 0x0400B3AF RID: 45999
		[Nullable(2)]
		private TArray<FName> _BindSocketNames;

		// Token: 0x0400B3B0 RID: 46000
		internal static int __PropertyOffset_AddRadius;

		// Token: 0x0400B3B1 RID: 46001
		internal static int __PropertyOffset_MinRadius;

		// Token: 0x0400B3B2 RID: 46002
		internal static int __PropertyOffset_MaxRadius;

		// Token: 0x0400B3B3 RID: 46003
		internal static int __PropertyOffset_AdjustCapsuleType;
	}
}
