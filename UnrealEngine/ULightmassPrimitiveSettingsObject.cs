using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D59 RID: 3417
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LightmassPrimitiveSettingsObject")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class ULightmassPrimitiveSettingsObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B867 RID: 47207 RVA: 0x0010670C File Offset: 0x0010490C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightmassPrimitiveSettingsObject._ClassPtr;
		}

		// Token: 0x0600B868 RID: 47208 RVA: 0x00106718 File Offset: 0x00104918
		public ULightmassPrimitiveSettingsObject() : this(BuiltinUtils.AllocNativeUObject(ULightmassPrimitiveSettingsObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B869 RID: 47209 RVA: 0x00106740 File Offset: 0x00104940
		public ULightmassPrimitiveSettingsObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULightmassPrimitiveSettingsObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x0600B86A RID: 47210 RVA: 0x00106774 File Offset: 0x00104974
		// (set) Token: 0x0600B86B RID: 47211 RVA: 0x001067AD File Offset: 0x001049AD
		public FLightmassPrimitiveSettings LightmassSettings
		{
			get
			{
				base.FastCheckIsValid();
				FLightmassPrimitiveSettings result;
				if ((result = this._LightmassSettings) == null)
				{
					result = (this._LightmassSettings = new FLightmassPrimitiveSettings(base.NativePtr + (IntPtr)ULightmassPrimitiveSettingsObject.__PropertyOffset_LightmassSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightmassPrimitiveSettings.StaticStruct(), base.NativePtr + (IntPtr)ULightmassPrimitiveSettingsObject.__PropertyOffset_LightmassSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600B86C RID: 47212 RVA: 0x001067CE File Offset: 0x001049CE
		static ULightmassPrimitiveSettingsObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightmassPrimitiveSettingsObject");
		}

		// Token: 0x0600B86D RID: 47213 RVA: 0x001067DC File Offset: 0x001049DC
		protected ULightmassPrimitiveSettingsObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040060A2 RID: 24738
		public new const string __ObjectPath = "/Script/Engine.LightmassPrimitiveSettingsObject";

		// Token: 0x040060A3 RID: 24739
		private static IntPtr _ClassPtr;

		// Token: 0x040060A4 RID: 24740
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040060A5 RID: 24741
		internal static int __PropertyOffset_LightmassSettings;

		// Token: 0x040060A6 RID: 24742
		[Nullable(2)]
		private FLightmassPrimitiveSettings _LightmassSettings;
	}
}
