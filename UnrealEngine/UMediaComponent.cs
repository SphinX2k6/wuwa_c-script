using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002296 RID: 8854
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaAssets.MediaComponent")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UMediaComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021A1C RID: 137756 RVA: 0x0031C279 File Offset: 0x0031A479
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaComponent._ClassPtr;
		}

		// Token: 0x06021A1D RID: 137757 RVA: 0x0031C288 File Offset: 0x0031A488
		public UMediaComponent() : this(BuiltinUtils.AllocNativeUObject(UMediaComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021A1E RID: 137758 RVA: 0x0031C2B0 File Offset: 0x0031A4B0
		[NullableContext(1)]
		public UMediaComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082A7 RID: 33447
		// (get) Token: 0x06021A1F RID: 137759 RVA: 0x0031C2E3 File Offset: 0x0031A4E3
		// (set) Token: 0x06021A20 RID: 137760 RVA: 0x0031C2F7 File Offset: 0x0031A4F7
		public unsafe UMediaTexture MediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UMediaComponent.__PropertyOffset_MediaTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMediaComponent.__PropertyOffset_MediaTexture, value);
			}
		}

		// Token: 0x170082A8 RID: 33448
		// (get) Token: 0x06021A21 RID: 137761 RVA: 0x0031C30C File Offset: 0x0031A50C
		// (set) Token: 0x06021A22 RID: 137762 RVA: 0x0031C320 File Offset: 0x0031A520
		public unsafe UMediaPlayer MediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UMediaComponent.__PropertyOffset_MediaPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMediaComponent.__PropertyOffset_MediaPlayer, value);
			}
		}

		// Token: 0x06021A23 RID: 137763 RVA: 0x0031C335 File Offset: 0x0031A535
		public UMediaTexture GetMediaTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaTexture>(UMediaComponent.__GetMediaTexture_Internal(base.NativePtr));
		}

		// Token: 0x06021A24 RID: 137764 RVA: 0x0031C347 File Offset: 0x0031A547
		public UMediaPlayer GetMediaPlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaPlayer>(UMediaComponent.__GetMediaPlayer_Internal(base.NativePtr));
		}

		// Token: 0x06021A25 RID: 137765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMediaTexture_Internal(IntPtr @this);

		// Token: 0x06021A26 RID: 137766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMediaPlayer_Internal(IntPtr @this);

		// Token: 0x06021A27 RID: 137767 RVA: 0x0031C359 File Offset: 0x0031A559
		static UMediaComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaComponent");
		}

		// Token: 0x06021A28 RID: 137768 RVA: 0x0031C367 File Offset: 0x0031A567
		protected UMediaComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F70 RID: 73584
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.MediaComponent";

		// Token: 0x04011F71 RID: 73585
		private static IntPtr _ClassPtr;

		// Token: 0x04011F72 RID: 73586
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F73 RID: 73587
		internal static int __PropertyOffset_MediaTexture;

		// Token: 0x04011F74 RID: 73588
		internal static int __PropertyOffset_MediaPlayer;
	}
}
