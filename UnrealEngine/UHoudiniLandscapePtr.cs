using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014E0 RID: 5344
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniLandscapePtr")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UHoudiniLandscapePtr : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601359F RID: 79263 RVA: 0x001C74AD File Offset: 0x001C56AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniLandscapePtr._ClassPtr;
		}

		// Token: 0x060135A0 RID: 79264 RVA: 0x001C74BC File Offset: 0x001C56BC
		public UHoudiniLandscapePtr() : this(BuiltinUtils.AllocNativeUObject(UHoudiniLandscapePtr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060135A1 RID: 79265 RVA: 0x001C74E4 File Offset: 0x001C56E4
		public UHoudiniLandscapePtr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniLandscapePtr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B70 RID: 19312
		// (get) Token: 0x060135A2 RID: 79266 RVA: 0x001C7517 File Offset: 0x001C5717
		// (set) Token: 0x060135A3 RID: 79267 RVA: 0x001C752C File Offset: 0x001C572C
		public TSoftObjectPtr<ALandscapeProxy> LandscapeSoftPtr
		{
			get
			{
				return new TSoftObjectPtr<ALandscapeProxy>(base.NativePtr + (IntPtr)UHoudiniLandscapePtr.__PropertyOffset_LandscapeSoftPtr, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UHoudiniLandscapePtr.__PropertyOffset_LandscapeSoftPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004B71 RID: 19313
		// (get) Token: 0x060135A4 RID: 79268 RVA: 0x001C7551 File Offset: 0x001C5751
		// (set) Token: 0x060135A5 RID: 79269 RVA: 0x001C7561 File Offset: 0x001C5761
		public unsafe EHoudiniLandscapeOutputBakeType BakeType
		{
			get
			{
				return (EHoudiniLandscapeOutputBakeType)(*(base.NativePtr + (IntPtr)UHoudiniLandscapePtr.__PropertyOffset_BakeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniLandscapePtr.__PropertyOffset_BakeType) = (byte)value;
			}
		}

		// Token: 0x17004B72 RID: 19314
		// (get) Token: 0x060135A6 RID: 79270 RVA: 0x001C7572 File Offset: 0x001C5772
		// (set) Token: 0x060135A7 RID: 79271 RVA: 0x001C7586 File Offset: 0x001C5786
		public unsafe FName EditLayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniLandscapePtr.__PropertyOffset_EditLayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniLandscapePtr.__PropertyOffset_EditLayerName) = value;
			}
		}

		// Token: 0x060135A8 RID: 79272 RVA: 0x001C759B File Offset: 0x001C579B
		static UHoudiniLandscapePtr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniLandscapePtr");
		}

		// Token: 0x060135A9 RID: 79273 RVA: 0x001C75A9 File Offset: 0x001C57A9
		protected UHoudiniLandscapePtr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A745 RID: 42821
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniLandscapePtr";

		// Token: 0x0400A746 RID: 42822
		private static IntPtr _ClassPtr;

		// Token: 0x0400A747 RID: 42823
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A748 RID: 42824
		internal static int __PropertyOffset_LandscapeSoftPtr;

		// Token: 0x0400A749 RID: 42825
		internal static int __PropertyOffset_BakeType;

		// Token: 0x0400A74A RID: 42826
		internal static int __PropertyOffset_EditLayerName;
	}
}
