using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F88 RID: 8072
	[UnrealObjectPath("/Script/Landscape.LandscapeSettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class ULandscapeSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EA6F RID: 125551 RVA: 0x002D90B7 File Offset: 0x002D72B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeSettings._ClassPtr;
		}

		// Token: 0x0601EA70 RID: 125552 RVA: 0x002D90C4 File Offset: 0x002D72C4
		public ULandscapeSettings() : this(BuiltinUtils.AllocNativeUObject(ULandscapeSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EA71 RID: 125553 RVA: 0x002D90EC File Offset: 0x002D72EC
		[NullableContext(1)]
		public ULandscapeSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A11 RID: 31249
		// (get) Token: 0x0601EA72 RID: 125554 RVA: 0x002D911F File Offset: 0x002D731F
		// (set) Token: 0x0601EA73 RID: 125555 RVA: 0x002D912F File Offset: 0x002D732F
		public unsafe int MaxNumberOfLayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSettings.__PropertyOffset_MaxNumberOfLayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSettings.__PropertyOffset_MaxNumberOfLayers) = value;
			}
		}

		// Token: 0x0601EA74 RID: 125556 RVA: 0x002D9140 File Offset: 0x002D7340
		static ULandscapeSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeSettings");
		}

		// Token: 0x0601EA75 RID: 125557 RVA: 0x002D914E File Offset: 0x002D734E
		protected ULandscapeSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401091E RID: 67870
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeSettings";

		// Token: 0x0401091F RID: 67871
		private static IntPtr _ClassPtr;

		// Token: 0x04010920 RID: 67872
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010921 RID: 67873
		internal static int __PropertyOffset_MaxNumberOfLayers;
	}
}
