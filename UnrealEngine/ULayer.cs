using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200022F RID: 559
	[UnrealObjectPath("/Script/Engine.Layer")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class ULayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002D25 RID: 11557 RVA: 0x0003FBEE File Offset: 0x0003DDEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULayer._ClassPtr;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x0003FBFC File Offset: 0x0003DDFC
		public ULayer() : this(BuiltinUtils.AllocNativeUObject(ULayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x0003FC24 File Offset: 0x0003DE24
		[NullableContext(1)]
		public ULayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06002D28 RID: 11560 RVA: 0x0003FC57 File Offset: 0x0003DE57
		// (set) Token: 0x06002D29 RID: 11561 RVA: 0x0003FC6B File Offset: 0x0003DE6B
		public unsafe FName LayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULayer.__PropertyOffset_LayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULayer.__PropertyOffset_LayerName) = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x0003FC80 File Offset: 0x0003DE80
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x0003FC99 File Offset: 0x0003DE99
		public unsafe bool bIsVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULayer.__PropertyOffset_bIsVisible) & ULayer.__PropertyMask_bIsVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULayer.__PropertyOffset_bIsVisible) = ((*(base.NativePtr + (IntPtr)ULayer.__PropertyOffset_bIsVisible) & ~ULayer.__PropertyMask_bIsVisible) | (value ? ULayer.__PropertyMask_bIsVisible : 0));
			}
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x0003FCC9 File Offset: 0x0003DEC9
		static ULayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Layer");
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x0003FCD7 File Offset: 0x0003DED7
		protected ULayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E52 RID: 3666
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Layer";

		// Token: 0x04000E53 RID: 3667
		private static IntPtr _ClassPtr;

		// Token: 0x04000E54 RID: 3668
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E55 RID: 3669
		internal static int __PropertyOffset_LayerName;

		// Token: 0x04000E56 RID: 3670
		internal static int __PropertyOffset_bIsVisible;

		// Token: 0x04000E57 RID: 3671
		internal static byte __PropertyMask_bIsVisible;
	}
}
