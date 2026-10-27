using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200166F RID: 5743
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroQuadrupedIK_Settings")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1144)]
	public class UKuroQuadrupedIK_Settings : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014D14 RID: 85268 RVA: 0x001E9BB2 File Offset: 0x001E7DB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroQuadrupedIK_Settings._ClassPtr;
		}

		// Token: 0x06014D15 RID: 85269 RVA: 0x001E9BC0 File Offset: 0x001E7DC0
		public UKuroQuadrupedIK_Settings() : this(BuiltinUtils.AllocNativeUObject(UKuroQuadrupedIK_Settings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014D16 RID: 85270 RVA: 0x001E9BE8 File Offset: 0x001E7DE8
		public UKuroQuadrupedIK_Settings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroQuadrupedIK_Settings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005265 RID: 21093
		// (get) Token: 0x06014D17 RID: 85271 RVA: 0x001E9C1C File Offset: 0x001E7E1C
		// (set) Token: 0x06014D18 RID: 85272 RVA: 0x001E9C55 File Offset: 0x001E7E55
		public FKuroQuadrupedIK_BasicSettings Basic
		{
			get
			{
				base.FastCheckIsValid();
				FKuroQuadrupedIK_BasicSettings result;
				if ((result = this._Basic) == null)
				{
					result = (this._Basic = new FKuroQuadrupedIK_BasicSettings(base.NativePtr + (IntPtr)UKuroQuadrupedIK_Settings.__PropertyOffset_Basic, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroQuadrupedIK_BasicSettings.StaticStruct(), base.NativePtr + (IntPtr)UKuroQuadrupedIK_Settings.__PropertyOffset_Basic, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005266 RID: 21094
		// (get) Token: 0x06014D19 RID: 85273 RVA: 0x001E9C78 File Offset: 0x001E7E78
		// (set) Token: 0x06014D1A RID: 85274 RVA: 0x001E9CB1 File Offset: 0x001E7EB1
		public FKuroQuadrupedIK_SpineSettings Spine
		{
			get
			{
				base.FastCheckIsValid();
				FKuroQuadrupedIK_SpineSettings result;
				if ((result = this._Spine) == null)
				{
					result = (this._Spine = new FKuroQuadrupedIK_SpineSettings(base.NativePtr + (IntPtr)UKuroQuadrupedIK_Settings.__PropertyOffset_Spine, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroQuadrupedIK_SpineSettings.StaticStruct(), base.NativePtr + (IntPtr)UKuroQuadrupedIK_Settings.__PropertyOffset_Spine, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005267 RID: 21095
		// (get) Token: 0x06014D1B RID: 85275 RVA: 0x001E9CD4 File Offset: 0x001E7ED4
		// (set) Token: 0x06014D1C RID: 85276 RVA: 0x001E9D0D File Offset: 0x001E7F0D
		public FKuroQuadrupedIK_FeetSettings Feet
		{
			get
			{
				base.FastCheckIsValid();
				FKuroQuadrupedIK_FeetSettings result;
				if ((result = this._Feet) == null)
				{
					result = (this._Feet = new FKuroQuadrupedIK_FeetSettings(base.NativePtr + (IntPtr)UKuroQuadrupedIK_Settings.__PropertyOffset_Feet, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroQuadrupedIK_FeetSettings.StaticStruct(), base.NativePtr + (IntPtr)UKuroQuadrupedIK_Settings.__PropertyOffset_Feet, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005268 RID: 21096
		// (get) Token: 0x06014D1D RID: 85277 RVA: 0x001E9D30 File Offset: 0x001E7F30
		// (set) Token: 0x06014D1E RID: 85278 RVA: 0x001E9D69 File Offset: 0x001E7F69
		public FKuroQuadrupedIK_DebugSettings Debug
		{
			get
			{
				base.FastCheckIsValid();
				FKuroQuadrupedIK_DebugSettings result;
				if ((result = this._Debug) == null)
				{
					result = (this._Debug = new FKuroQuadrupedIK_DebugSettings(base.NativePtr + (IntPtr)UKuroQuadrupedIK_Settings.__PropertyOffset_Debug, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroQuadrupedIK_DebugSettings.StaticStruct(), base.NativePtr + (IntPtr)UKuroQuadrupedIK_Settings.__PropertyOffset_Debug, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06014D1F RID: 85279 RVA: 0x001E9D8A File Offset: 0x001E7F8A
		static UKuroQuadrupedIK_Settings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroQuadrupedIK_Settings");
		}

		// Token: 0x06014D20 RID: 85280 RVA: 0x001E9D98 File Offset: 0x001E7F98
		protected UKuroQuadrupedIK_Settings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B58B RID: 46475
		public new const string __ObjectPath = "/Script/KuroAnim.KuroQuadrupedIK_Settings";

		// Token: 0x0400B58C RID: 46476
		private static IntPtr _ClassPtr;

		// Token: 0x0400B58D RID: 46477
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B58E RID: 46478
		internal static int __PropertyOffset_Basic;

		// Token: 0x0400B58F RID: 46479
		[Nullable(2)]
		private FKuroQuadrupedIK_BasicSettings _Basic;

		// Token: 0x0400B590 RID: 46480
		internal static int __PropertyOffset_Spine;

		// Token: 0x0400B591 RID: 46481
		[Nullable(2)]
		private FKuroQuadrupedIK_SpineSettings _Spine;

		// Token: 0x0400B592 RID: 46482
		internal static int __PropertyOffset_Feet;

		// Token: 0x0400B593 RID: 46483
		[Nullable(2)]
		private FKuroQuadrupedIK_FeetSettings _Feet;

		// Token: 0x0400B594 RID: 46484
		internal static int __PropertyOffset_Debug;

		// Token: 0x0400B595 RID: 46485
		[Nullable(2)]
		private FKuroQuadrupedIK_DebugSettings _Debug;
	}
}
