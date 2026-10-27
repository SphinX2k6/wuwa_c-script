using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200151C RID: 5404
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ImgMedia.ImgMediaSource")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UImgMediaSource : UBaseMediaSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013AD2 RID: 80594 RVA: 0x001CE6F6 File Offset: 0x001CC8F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImgMediaSource._ClassPtr;
		}

		// Token: 0x06013AD3 RID: 80595 RVA: 0x001CE704 File Offset: 0x001CC904
		public UImgMediaSource() : this(BuiltinUtils.AllocNativeUObject(UImgMediaSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013AD4 RID: 80596 RVA: 0x001CE72C File Offset: 0x001CC92C
		public UImgMediaSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImgMediaSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D08 RID: 19720
		// (get) Token: 0x06013AD5 RID: 80597 RVA: 0x001CE75F File Offset: 0x001CC95F
		// (set) Token: 0x06013AD6 RID: 80598 RVA: 0x001CE773 File Offset: 0x001CC973
		public unsafe FFrameRate FrameRateOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImgMediaSource.__PropertyOffset_FrameRateOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImgMediaSource.__PropertyOffset_FrameRateOverride) = value;
			}
		}

		// Token: 0x17004D09 RID: 19721
		// (get) Token: 0x06013AD7 RID: 80599 RVA: 0x001CE788 File Offset: 0x001CC988
		// (set) Token: 0x06013AD8 RID: 80600 RVA: 0x001CE79C File Offset: 0x001CC99C
		public unsafe string ProxyOverride
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UImgMediaSource.__PropertyOffset_ProxyOverride)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UImgMediaSource.__PropertyOffset_ProxyOverride)), value);
			}
		}

		// Token: 0x17004D0A RID: 19722
		// (get) Token: 0x06013AD9 RID: 80601 RVA: 0x001CE7B4 File Offset: 0x001CC9B4
		// (set) Token: 0x06013ADA RID: 80602 RVA: 0x001CE7ED File Offset: 0x001CC9ED
		public FDirectoryPath SequencePath
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._SequencePath) == null)
				{
					result = (this._SequencePath = new FDirectoryPath(base.NativePtr + (IntPtr)UImgMediaSource.__PropertyOffset_SequencePath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UImgMediaSource.__PropertyOffset_SequencePath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06013ADB RID: 80603 RVA: 0x001CE810 File Offset: 0x001CCA10
		public unsafe void SetSequencePath(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UImgMediaSource.__SetSequencePath_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06013ADC RID: 80604 RVA: 0x001CE83A File Offset: 0x001CCA3A
		public string GetSequencePath()
		{
			return FString.ToStringAndDeleteNativePtr(UImgMediaSource.__GetSequencePath_Internal(base.NativePtr));
		}

		// Token: 0x06013ADD RID: 80605 RVA: 0x001CE84C File Offset: 0x001CCA4C
		public void GetProxies([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutProxies)
		{
			UImgMediaSource.__GetProxies_Internal(base.NativePtr, (OutProxies ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06013ADE RID: 80606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSequencePath_Internal(IntPtr @this, in FString Path);

		// Token: 0x06013ADF RID: 80607
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSequencePath_Internal(IntPtr @this);

		// Token: 0x06013AE0 RID: 80608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetProxies_Internal(IntPtr @this, IntPtr OutProxies);

		// Token: 0x06013AE1 RID: 80609 RVA: 0x001CE869 File Offset: 0x001CCA69
		static UImgMediaSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ImgMedia.ImgMediaSource");
		}

		// Token: 0x06013AE2 RID: 80610 RVA: 0x001CE877 File Offset: 0x001CCA77
		protected UImgMediaSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A9F6 RID: 43510
		public new const string __ObjectPath = "/Script/ImgMedia.ImgMediaSource";

		// Token: 0x0400A9F7 RID: 43511
		private static IntPtr _ClassPtr;

		// Token: 0x0400A9F8 RID: 43512
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A9F9 RID: 43513
		internal static int __PropertyOffset_FrameRateOverride;

		// Token: 0x0400A9FA RID: 43514
		internal static int __PropertyOffset_ProxyOverride;

		// Token: 0x0400A9FB RID: 43515
		internal static int __PropertyOffset_SequencePath;

		// Token: 0x0400A9FC RID: 43516
		[Nullable(2)]
		private FDirectoryPath _SequencePath;
	}
}
