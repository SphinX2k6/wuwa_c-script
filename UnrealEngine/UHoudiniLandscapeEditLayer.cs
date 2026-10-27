using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014DF RID: 5343
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniLandscapeEditLayer")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UHoudiniLandscapeEditLayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013596 RID: 79254 RVA: 0x001C73CC File Offset: 0x001C55CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniLandscapeEditLayer._ClassPtr;
		}

		// Token: 0x06013597 RID: 79255 RVA: 0x001C73D8 File Offset: 0x001C55D8
		public UHoudiniLandscapeEditLayer() : this(BuiltinUtils.AllocNativeUObject(UHoudiniLandscapeEditLayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013598 RID: 79256 RVA: 0x001C7400 File Offset: 0x001C5600
		public UHoudiniLandscapeEditLayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniLandscapeEditLayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B6E RID: 19310
		// (get) Token: 0x06013599 RID: 79257 RVA: 0x001C7433 File Offset: 0x001C5633
		// (set) Token: 0x0601359A RID: 79258 RVA: 0x001C7448 File Offset: 0x001C5648
		public TSoftObjectPtr<ALandscapeProxy> LandscapeSoftPtr
		{
			get
			{
				return new TSoftObjectPtr<ALandscapeProxy>(base.NativePtr + (IntPtr)UHoudiniLandscapeEditLayer.__PropertyOffset_LandscapeSoftPtr, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UHoudiniLandscapeEditLayer.__PropertyOffset_LandscapeSoftPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004B6F RID: 19311
		// (get) Token: 0x0601359B RID: 79259 RVA: 0x001C746D File Offset: 0x001C566D
		// (set) Token: 0x0601359C RID: 79260 RVA: 0x001C7481 File Offset: 0x001C5681
		public unsafe string LayerName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniLandscapeEditLayer.__PropertyOffset_LayerName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniLandscapeEditLayer.__PropertyOffset_LayerName)), value);
			}
		}

		// Token: 0x0601359D RID: 79261 RVA: 0x001C7496 File Offset: 0x001C5696
		static UHoudiniLandscapeEditLayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniLandscapeEditLayer");
		}

		// Token: 0x0601359E RID: 79262 RVA: 0x001C74A4 File Offset: 0x001C56A4
		protected UHoudiniLandscapeEditLayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A740 RID: 42816
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniLandscapeEditLayer";

		// Token: 0x0400A741 RID: 42817
		private static IntPtr _ClassPtr;

		// Token: 0x0400A742 RID: 42818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A743 RID: 42819
		internal static int __PropertyOffset_LandscapeSoftPtr;

		// Token: 0x0400A744 RID: 42820
		internal static int __PropertyOffset_LayerName;
	}
}
