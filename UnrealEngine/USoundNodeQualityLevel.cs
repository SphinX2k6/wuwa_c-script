using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200114C RID: 4428
	[UnrealObjectPath("/Script/Engine.SoundNodeQualityLevel")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class USoundNodeQualityLevel : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060102D9 RID: 66265 RVA: 0x0017D6D7 File Offset: 0x0017B8D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeQualityLevel._ClassPtr;
		}

		// Token: 0x060102DA RID: 66266 RVA: 0x0017D6E4 File Offset: 0x0017B8E4
		public USoundNodeQualityLevel() : this(BuiltinUtils.AllocNativeUObject(USoundNodeQualityLevel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060102DB RID: 66267 RVA: 0x0017D70C File Offset: 0x0017B90C
		[NullableContext(1)]
		public USoundNodeQualityLevel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeQualityLevel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x060102DC RID: 66268 RVA: 0x0017D73F File Offset: 0x0017B93F
		// (set) Token: 0x060102DD RID: 66269 RVA: 0x0017D74F File Offset: 0x0017B94F
		public unsafe int CookedQualityLevelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeQualityLevel.__PropertyOffset_CookedQualityLevelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeQualityLevel.__PropertyOffset_CookedQualityLevelIndex) = value;
			}
		}

		// Token: 0x060102DE RID: 66270 RVA: 0x0017D760 File Offset: 0x0017B960
		static USoundNodeQualityLevel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeQualityLevel");
		}

		// Token: 0x060102DF RID: 66271 RVA: 0x0017D76E File Offset: 0x0017B96E
		protected USoundNodeQualityLevel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B47 RID: 35655
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeQualityLevel";

		// Token: 0x04008B48 RID: 35656
		private static IntPtr _ClassPtr;

		// Token: 0x04008B49 RID: 35657
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B4A RID: 35658
		internal static int __PropertyOffset_CookedQualityLevelIndex;
	}
}
