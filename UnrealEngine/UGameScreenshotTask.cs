using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001944 RID: 6468
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameScreenshot.GameScreenshotTask")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UGameScreenshotTask : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017F80 RID: 98176 RVA: 0x0023244F File Offset: 0x0023064F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameScreenshotTask._ClassPtr;
		}

		// Token: 0x06017F81 RID: 98177 RVA: 0x0023245C File Offset: 0x0023065C
		public UGameScreenshotTask() : this(BuiltinUtils.AllocNativeUObject(UGameScreenshotTask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017F82 RID: 98178 RVA: 0x00232484 File Offset: 0x00230684
		public UGameScreenshotTask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameScreenshotTask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700600C RID: 24588
		// (get) Token: 0x06017F83 RID: 98179 RVA: 0x002324B8 File Offset: 0x002306B8
		// (set) Token: 0x06017F84 RID: 98180 RVA: 0x002324F1 File Offset: 0x002306F1
		public FOnTakeScreenshotCaptured OnTakeScreenshotCapturedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnTakeScreenshotCaptured result;
				if ((result = this._OnTakeScreenshotCapturedDelegate) == null)
				{
					result = (this._OnTakeScreenshotCapturedDelegate = new FOnTakeScreenshotCaptured(base.NativePtr + (IntPtr)UGameScreenshotTask.__PropertyOffset_OnTakeScreenshotCapturedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameScreenshotTask.__PropertyOffset_OnTakeScreenshotCapturedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700600D RID: 24589
		// (get) Token: 0x06017F85 RID: 98181 RVA: 0x00232514 File Offset: 0x00230714
		// (set) Token: 0x06017F86 RID: 98182 RVA: 0x0023254D File Offset: 0x0023074D
		public FOnTakeScreenshotCompressed OnTakeScreenshotCompressedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnTakeScreenshotCompressed result;
				if ((result = this._OnTakeScreenshotCompressedDelegate) == null)
				{
					result = (this._OnTakeScreenshotCompressedDelegate = new FOnTakeScreenshotCompressed(base.NativePtr + (IntPtr)UGameScreenshotTask.__PropertyOffset_OnTakeScreenshotCompressedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameScreenshotTask.__PropertyOffset_OnTakeScreenshotCompressedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700600E RID: 24590
		// (get) Token: 0x06017F87 RID: 98183 RVA: 0x00232570 File Offset: 0x00230770
		// (set) Token: 0x06017F88 RID: 98184 RVA: 0x002325A9 File Offset: 0x002307A9
		public FOnIOSPhotoLibraryAuthorizationCompleted OnIOSPhotoLibraryAuthorizationCompletedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnIOSPhotoLibraryAuthorizationCompleted result;
				if ((result = this._OnIOSPhotoLibraryAuthorizationCompletedDelegate) == null)
				{
					result = (this._OnIOSPhotoLibraryAuthorizationCompletedDelegate = new FOnIOSPhotoLibraryAuthorizationCompleted(base.NativePtr + (IntPtr)UGameScreenshotTask.__PropertyOffset_OnIOSPhotoLibraryAuthorizationCompletedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameScreenshotTask.__PropertyOffset_OnIOSPhotoLibraryAuthorizationCompletedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700600F RID: 24591
		// (get) Token: 0x06017F89 RID: 98185 RVA: 0x002325CC File Offset: 0x002307CC
		// (set) Token: 0x06017F8A RID: 98186 RVA: 0x00232605 File Offset: 0x00230805
		public FOnHighResShotSaved OnHighResShotSavedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnHighResShotSaved result;
				if ((result = this._OnHighResShotSavedDelegate) == null)
				{
					result = (this._OnHighResShotSavedDelegate = new FOnHighResShotSaved(base.NativePtr + (IntPtr)UGameScreenshotTask.__PropertyOffset_OnHighResShotSavedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameScreenshotTask.__PropertyOffset_OnHighResShotSavedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06017F8B RID: 98187 RVA: 0x00232626 File Offset: 0x00230826
		public bool TakeScreenshotHighRes(int MultiplierScale)
		{
			return UGameScreenshotTask.__TakeScreenshotHighRes_Internal(base.NativePtr, MultiplierScale);
		}

		// Token: 0x06017F8C RID: 98188 RVA: 0x00232634 File Offset: 0x00230834
		public bool TakeScreenshot()
		{
			return UGameScreenshotTask.__TakeScreenshot_Internal(base.NativePtr);
		}

		// Token: 0x06017F8D RID: 98189 RVA: 0x00232641 File Offset: 0x00230841
		public void Reset()
		{
			UGameScreenshotTask.__Reset_Internal(base.NativePtr);
		}

		// Token: 0x06017F8E RID: 98190 RVA: 0x0023264E File Offset: 0x0023084E
		public void RequestIOSPhotoLibraryAuthorization()
		{
			UGameScreenshotTask.__RequestIOSPhotoLibraryAuthorization_Internal(base.NativePtr);
		}

		// Token: 0x06017F8F RID: 98191 RVA: 0x0023265B File Offset: 0x0023085B
		[NullableContext(2)]
		public void OnScreenshotCompressed(in TArray<byte> CompressedBitMap)
		{
			UGameScreenshotTask.__OnScreenshotCompressed_Internal(base.NativePtr, (CompressedBitMap ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x06017F90 RID: 98192 RVA: 0x00232678 File Offset: 0x00230878
		[NullableContext(2)]
		public void OnScreenshotCaptured(int Width, int Height, in TArray<FColor> Colors)
		{
			UGameScreenshotTask.__OnScreenshotCaptured_Internal(base.NativePtr, Width, Height, (Colors ?? new TArray<FColor>()).NativePtr);
		}

		// Token: 0x06017F91 RID: 98193 RVA: 0x00232697 File Offset: 0x00230897
		public void OnIOSPhotoLibraryAuthorizationCompleted(bool IsGranted)
		{
			UGameScreenshotTask.__OnIOSPhotoLibraryAuthorizationCompleted_Internal(base.NativePtr, IsGranted);
		}

		// Token: 0x06017F92 RID: 98194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TakeScreenshotHighRes_Internal(IntPtr @this, int MultiplierScale);

		// Token: 0x06017F93 RID: 98195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TakeScreenshot_Internal(IntPtr @this);

		// Token: 0x06017F94 RID: 98196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Reset_Internal(IntPtr @this);

		// Token: 0x06017F95 RID: 98197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestIOSPhotoLibraryAuthorization_Internal(IntPtr @this);

		// Token: 0x06017F96 RID: 98198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnScreenshotCompressed_Internal(IntPtr @this, IntPtr CompressedBitMap);

		// Token: 0x06017F97 RID: 98199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnScreenshotCaptured_Internal(IntPtr @this, int Width, int Height, IntPtr Colors);

		// Token: 0x06017F98 RID: 98200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnIOSPhotoLibraryAuthorizationCompleted_Internal(IntPtr @this, bool IsGranted);

		// Token: 0x06017F99 RID: 98201 RVA: 0x002326A5 File Offset: 0x002308A5
		static UGameScreenshotTask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameScreenshot.GameScreenshotTask");
		}

		// Token: 0x06017F9A RID: 98202 RVA: 0x002326B3 File Offset: 0x002308B3
		protected UGameScreenshotTask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CF76 RID: 53110
		public new const string __ObjectPath = "/Script/KuroGameScreenshot.GameScreenshotTask";

		// Token: 0x0400CF77 RID: 53111
		private static IntPtr _ClassPtr;

		// Token: 0x0400CF78 RID: 53112
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CF79 RID: 53113
		internal static int __PropertyOffset_OnTakeScreenshotCapturedDelegate;

		// Token: 0x0400CF7A RID: 53114
		[Nullable(2)]
		private FOnTakeScreenshotCaptured _OnTakeScreenshotCapturedDelegate;

		// Token: 0x0400CF7B RID: 53115
		internal static int __PropertyOffset_OnTakeScreenshotCompressedDelegate;

		// Token: 0x0400CF7C RID: 53116
		[Nullable(2)]
		private FOnTakeScreenshotCompressed _OnTakeScreenshotCompressedDelegate;

		// Token: 0x0400CF7D RID: 53117
		internal static int __PropertyOffset_OnIOSPhotoLibraryAuthorizationCompletedDelegate;

		// Token: 0x0400CF7E RID: 53118
		[Nullable(2)]
		private FOnIOSPhotoLibraryAuthorizationCompleted _OnIOSPhotoLibraryAuthorizationCompletedDelegate;

		// Token: 0x0400CF7F RID: 53119
		internal static int __PropertyOffset_OnHighResShotSavedDelegate;

		// Token: 0x0400CF80 RID: 53120
		[Nullable(2)]
		private FOnHighResShotSaved _OnHighResShotSavedDelegate;
	}
}
