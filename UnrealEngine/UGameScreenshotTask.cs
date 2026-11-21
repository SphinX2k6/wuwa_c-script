using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000424 RID: 1060
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameScreenshot.GameScreenshotTask")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UGameScreenshotTask : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006623 RID: 26147 RVA: 0x00092AA0 File Offset: 0x00090CA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameScreenshotTask._ClassPtr;
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x00092AAC File Offset: 0x00090CAC
		public UGameScreenshotTask() : this(BuiltinUtils.AllocNativeUObject(UGameScreenshotTask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x00092AD4 File Offset: 0x00090CD4
		public UGameScreenshotTask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameScreenshotTask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06006626 RID: 26150 RVA: 0x00092B08 File Offset: 0x00090D08
		// (set) Token: 0x06006627 RID: 26151 RVA: 0x00092B41 File Offset: 0x00090D41
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

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06006628 RID: 26152 RVA: 0x00092B64 File Offset: 0x00090D64
		// (set) Token: 0x06006629 RID: 26153 RVA: 0x00092B9D File Offset: 0x00090D9D
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

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600662A RID: 26154 RVA: 0x00092BC0 File Offset: 0x00090DC0
		// (set) Token: 0x0600662B RID: 26155 RVA: 0x00092BF9 File Offset: 0x00090DF9
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

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x0600662C RID: 26156 RVA: 0x00092C1C File Offset: 0x00090E1C
		// (set) Token: 0x0600662D RID: 26157 RVA: 0x00092C55 File Offset: 0x00090E55
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

		// Token: 0x0600662E RID: 26158 RVA: 0x00092C76 File Offset: 0x00090E76
		public bool TakeScreenshotHighRes(int MultiplierScale)
		{
			return UGameScreenshotTask.__TakeScreenshotHighRes_Internal(base.NativePtr, MultiplierScale);
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x00092C84 File Offset: 0x00090E84
		public bool TakeScreenshot()
		{
			return UGameScreenshotTask.__TakeScreenshot_Internal(base.NativePtr);
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x00092C91 File Offset: 0x00090E91
		public void Reset()
		{
			UGameScreenshotTask.__Reset_Internal(base.NativePtr);
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x00092C9E File Offset: 0x00090E9E
		public void RequestIOSPhotoLibraryAuthorization()
		{
			UGameScreenshotTask.__RequestIOSPhotoLibraryAuthorization_Internal(base.NativePtr);
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x00092CAB File Offset: 0x00090EAB
		[NullableContext(2)]
		public void OnScreenshotCompressed(in TArray<byte> CompressedBitMap)
		{
			UGameScreenshotTask.__OnScreenshotCompressed_Internal(base.NativePtr, (CompressedBitMap ?? new TArray<byte>()).NativePtr);
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x00092CC8 File Offset: 0x00090EC8
		[NullableContext(2)]
		public void OnScreenshotCaptured(int Width, int Height, in TArray<FColor> Colors)
		{
			UGameScreenshotTask.__OnScreenshotCaptured_Internal(base.NativePtr, Width, Height, (Colors ?? new TArray<FColor>()).NativePtr);
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x00092CE7 File Offset: 0x00090EE7
		public void OnIOSPhotoLibraryAuthorizationCompleted(bool IsGranted)
		{
			UGameScreenshotTask.__OnIOSPhotoLibraryAuthorizationCompleted_Internal(base.NativePtr, IsGranted);
		}

		// Token: 0x06006635 RID: 26165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TakeScreenshotHighRes_Internal(IntPtr @this, int MultiplierScale);

		// Token: 0x06006636 RID: 26166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TakeScreenshot_Internal(IntPtr @this);

		// Token: 0x06006637 RID: 26167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Reset_Internal(IntPtr @this);

		// Token: 0x06006638 RID: 26168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestIOSPhotoLibraryAuthorization_Internal(IntPtr @this);

		// Token: 0x06006639 RID: 26169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnScreenshotCompressed_Internal(IntPtr @this, IntPtr CompressedBitMap);

		// Token: 0x0600663A RID: 26170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnScreenshotCaptured_Internal(IntPtr @this, int Width, int Height, IntPtr Colors);

		// Token: 0x0600663B RID: 26171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnIOSPhotoLibraryAuthorizationCompleted_Internal(IntPtr @this, bool IsGranted);

		// Token: 0x0600663C RID: 26172 RVA: 0x00092CF5 File Offset: 0x00090EF5
		static UGameScreenshotTask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameScreenshot.GameScreenshotTask");
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x00092D03 File Offset: 0x00090F03
		protected UGameScreenshotTask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002AF0 RID: 10992
		public new const string __ObjectPath = "/Script/KuroGameScreenshot.GameScreenshotTask";

		// Token: 0x04002AF1 RID: 10993
		private static IntPtr _ClassPtr;

		// Token: 0x04002AF2 RID: 10994
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002AF3 RID: 10995
		internal static int __PropertyOffset_OnTakeScreenshotCapturedDelegate;

		// Token: 0x04002AF4 RID: 10996
		[Nullable(2)]
		private FOnTakeScreenshotCaptured _OnTakeScreenshotCapturedDelegate;

		// Token: 0x04002AF5 RID: 10997
		internal static int __PropertyOffset_OnTakeScreenshotCompressedDelegate;

		// Token: 0x04002AF6 RID: 10998
		[Nullable(2)]
		private FOnTakeScreenshotCompressed _OnTakeScreenshotCompressedDelegate;

		// Token: 0x04002AF7 RID: 10999
		internal static int __PropertyOffset_OnIOSPhotoLibraryAuthorizationCompletedDelegate;

		// Token: 0x04002AF8 RID: 11000
		[Nullable(2)]
		private FOnIOSPhotoLibraryAuthorizationCompleted _OnIOSPhotoLibraryAuthorizationCompletedDelegate;

		// Token: 0x04002AF9 RID: 11001
		internal static int __PropertyOffset_OnHighResShotSavedDelegate;

		// Token: 0x04002AFA RID: 11002
		[Nullable(2)]
		private FOnHighResShotSaved _OnHighResShotSavedDelegate;
	}
}
