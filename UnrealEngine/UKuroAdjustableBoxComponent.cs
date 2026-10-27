using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001651 RID: 5713
	[UnrealObjectPath("/Script/KuroAnim.KuroAdjustableBoxComponent")]
	[UnrealStructLayout(1648, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1648)]
	public class UKuroAdjustableBoxComponent : UBoxComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014904 RID: 84228 RVA: 0x001E3EB4 File Offset: 0x001E20B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAdjustableBoxComponent._ClassPtr;
		}

		// Token: 0x06014905 RID: 84229 RVA: 0x001E3EC0 File Offset: 0x001E20C0
		public UKuroAdjustableBoxComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroAdjustableBoxComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014906 RID: 84230 RVA: 0x001E3EE8 File Offset: 0x001E20E8
		[NullableContext(1)]
		public UKuroAdjustableBoxComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAdjustableBoxComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170050F4 RID: 20724
		// (get) Token: 0x06014907 RID: 84231 RVA: 0x001E3F1C File Offset: 0x001E211C
		// (set) Token: 0x06014908 RID: 84232 RVA: 0x001E3F55 File Offset: 0x001E2155
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
					result = (this._BindSocketNames = new TArray<FName>(base.NativePtr + (IntPtr)UKuroAdjustableBoxComponent.__PropertyOffset_BindSocketNames, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BindSocketNames.CopyAssign(value);
			}
		}

		// Token: 0x170050F5 RID: 20725
		// (get) Token: 0x06014909 RID: 84233 RVA: 0x001E3F63 File Offset: 0x001E2163
		// (set) Token: 0x0601490A RID: 84234 RVA: 0x001E3F73 File Offset: 0x001E2173
		public unsafe float AddExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAdjustableBoxComponent.__PropertyOffset_AddExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAdjustableBoxComponent.__PropertyOffset_AddExtent) = value;
			}
		}

		// Token: 0x170050F6 RID: 20726
		// (get) Token: 0x0601490B RID: 84235 RVA: 0x001E3F84 File Offset: 0x001E2184
		// (set) Token: 0x0601490C RID: 84236 RVA: 0x001E3F94 File Offset: 0x001E2194
		public unsafe float MinExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAdjustableBoxComponent.__PropertyOffset_MinExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAdjustableBoxComponent.__PropertyOffset_MinExtent) = value;
			}
		}

		// Token: 0x170050F7 RID: 20727
		// (get) Token: 0x0601490D RID: 84237 RVA: 0x001E3FA5 File Offset: 0x001E21A5
		// (set) Token: 0x0601490E RID: 84238 RVA: 0x001E3FB5 File Offset: 0x001E21B5
		public unsafe float MaxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAdjustableBoxComponent.__PropertyOffset_MaxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAdjustableBoxComponent.__PropertyOffset_MaxExtent) = value;
			}
		}

		// Token: 0x170050F8 RID: 20728
		// (get) Token: 0x0601490F RID: 84239 RVA: 0x001E3FC6 File Offset: 0x001E21C6
		// (set) Token: 0x06014910 RID: 84240 RVA: 0x001E3FDA File Offset: 0x001E21DA
		public unsafe TEnumAsByte<EAdjustBoxType> AdjustBoxType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAdjustableBoxComponent.__PropertyOffset_AdjustBoxType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAdjustableBoxComponent.__PropertyOffset_AdjustBoxType) = value;
			}
		}

		// Token: 0x06014911 RID: 84241 RVA: 0x001E3FEF File Offset: 0x001E21EF
		static UKuroAdjustableBoxComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAdjustableBoxComponent");
		}

		// Token: 0x06014912 RID: 84242 RVA: 0x001E3FFD File Offset: 0x001E21FD
		protected UKuroAdjustableBoxComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B3A2 RID: 45986
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAdjustableBoxComponent";

		// Token: 0x0400B3A3 RID: 45987
		private static IntPtr _ClassPtr;

		// Token: 0x0400B3A4 RID: 45988
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B3A5 RID: 45989
		internal static int __PropertyOffset_BindSocketNames;

		// Token: 0x0400B3A6 RID: 45990
		[Nullable(2)]
		private TArray<FName> _BindSocketNames;

		// Token: 0x0400B3A7 RID: 45991
		internal static int __PropertyOffset_AddExtent;

		// Token: 0x0400B3A8 RID: 45992
		internal static int __PropertyOffset_MinExtent;

		// Token: 0x0400B3A9 RID: 45993
		internal static int __PropertyOffset_MaxExtent;

		// Token: 0x0400B3AA RID: 45994
		internal static int __PropertyOffset_AdjustBoxType;
	}
}
