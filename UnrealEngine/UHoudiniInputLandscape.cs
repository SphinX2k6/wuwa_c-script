using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014D4 RID: 5332
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputLandscape")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UHoudiniInputLandscape : UHoudiniInputActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013516 RID: 79126 RVA: 0x001C67A6 File Offset: 0x001C49A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputLandscape._ClassPtr;
		}

		// Token: 0x06013517 RID: 79127 RVA: 0x001C67B4 File Offset: 0x001C49B4
		public UHoudiniInputLandscape() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputLandscape.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013518 RID: 79128 RVA: 0x001C67DC File Offset: 0x001C49DC
		[NullableContext(1)]
		public UHoudiniInputLandscape(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputLandscape.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B4B RID: 19275
		// (get) Token: 0x06013519 RID: 79129 RVA: 0x001C680F File Offset: 0x001C4A0F
		// (set) Token: 0x0601351A RID: 79130 RVA: 0x001C6823 File Offset: 0x001C4A23
		public unsafe FTransform CachedInputLandscapeTraqnsform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputLandscape.__PropertyOffset_CachedInputLandscapeTraqnsform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputLandscape.__PropertyOffset_CachedInputLandscapeTraqnsform) = value;
			}
		}

		// Token: 0x17004B4C RID: 19276
		// (get) Token: 0x0601351B RID: 79131 RVA: 0x001C6838 File Offset: 0x001C4A38
		// (set) Token: 0x0601351C RID: 79132 RVA: 0x001C6848 File Offset: 0x001C4A48
		public unsafe int CachedNumLandscapeComponents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputLandscape.__PropertyOffset_CachedNumLandscapeComponents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputLandscape.__PropertyOffset_CachedNumLandscapeComponents) = value;
			}
		}

		// Token: 0x0601351D RID: 79133 RVA: 0x001C6859 File Offset: 0x001C4A59
		static UHoudiniInputLandscape()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputLandscape");
		}

		// Token: 0x0601351E RID: 79134 RVA: 0x001C6867 File Offset: 0x001C4A67
		protected UHoudiniInputLandscape(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6F5 RID: 42741
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputLandscape";

		// Token: 0x0400A6F6 RID: 42742
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6F7 RID: 42743
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A6F8 RID: 42744
		internal static int __PropertyOffset_CachedInputLandscapeTraqnsform;

		// Token: 0x0400A6F9 RID: 42745
		internal static int __PropertyOffset_CachedNumLandscapeComponents;
	}
}
