using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002310 RID: 8976
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneCapture.MovieSceneCapture")]
	[UnrealStructLayout(576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UMovieSceneCapture : UObject, IUnrealUObject, IUnrealObject, IMovieSceneCaptureInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06021FAD RID: 139181 RVA: 0x00323F2D File Offset: 0x0032212D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCapture._ClassPtr;
		}

		// Token: 0x06021FAE RID: 139182 RVA: 0x00323F39 File Offset: 0x00322139
		int IMovieSceneCaptureInterface.InterfaceOffset()
		{
			return UMovieSceneCapture.__InterfaceOffset_IMovieSceneCaptureInterface;
		}

		// Token: 0x06021FAF RID: 139183 RVA: 0x00323F40 File Offset: 0x00322140
		public UMovieSceneCapture() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCapture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021FB0 RID: 139184 RVA: 0x00323F68 File Offset: 0x00322168
		public UMovieSceneCapture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCapture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700834F RID: 33615
		// (get) Token: 0x06021FB1 RID: 139185 RVA: 0x00323F9C File Offset: 0x0032219C
		// (set) Token: 0x06021FB2 RID: 139186 RVA: 0x00323FD5 File Offset: 0x003221D5
		public FSoftClassPath ImageCaptureProtocolType
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._ImageCaptureProtocolType) == null)
				{
					result = (this._ImageCaptureProtocolType = new FSoftClassPath(base.NativePtr + (IntPtr)UMovieSceneCapture.__PropertyOffset_ImageCaptureProtocolType, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCapture.__PropertyOffset_ImageCaptureProtocolType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008350 RID: 33616
		// (get) Token: 0x06021FB3 RID: 139187 RVA: 0x00323FF8 File Offset: 0x003221F8
		// (set) Token: 0x06021FB4 RID: 139188 RVA: 0x00324031 File Offset: 0x00322231
		public FSoftClassPath AudioCaptureProtocolType
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._AudioCaptureProtocolType) == null)
				{
					result = (this._AudioCaptureProtocolType = new FSoftClassPath(base.NativePtr + (IntPtr)UMovieSceneCapture.__PropertyOffset_AudioCaptureProtocolType, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCapture.__PropertyOffset_AudioCaptureProtocolType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008351 RID: 33617
		// (get) Token: 0x06021FB5 RID: 139189 RVA: 0x00324052 File Offset: 0x00322252
		// (set) Token: 0x06021FB6 RID: 139190 RVA: 0x00324066 File Offset: 0x00322266
		[Nullable(2)]
		public unsafe UMovieSceneImageCaptureProtocolBase ImageCaptureProtocol
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneImageCaptureProtocolBase>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneCapture.__PropertyOffset_ImageCaptureProtocol);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneCapture.__PropertyOffset_ImageCaptureProtocol, value);
			}
		}

		// Token: 0x17008352 RID: 33618
		// (get) Token: 0x06021FB7 RID: 139191 RVA: 0x0032407B File Offset: 0x0032227B
		// (set) Token: 0x06021FB8 RID: 139192 RVA: 0x0032408F File Offset: 0x0032228F
		[Nullable(2)]
		public unsafe UMovieSceneAudioCaptureProtocolBase AudioCaptureProtocol
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneAudioCaptureProtocolBase>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneCapture.__PropertyOffset_AudioCaptureProtocol);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneCapture.__PropertyOffset_AudioCaptureProtocol, value);
			}
		}

		// Token: 0x17008353 RID: 33619
		// (get) Token: 0x06021FB9 RID: 139193 RVA: 0x003240A4 File Offset: 0x003222A4
		// (set) Token: 0x06021FBA RID: 139194 RVA: 0x003240DD File Offset: 0x003222DD
		public FMovieSceneCaptureSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneCaptureSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FMovieSceneCaptureSettings(base.NativePtr + (IntPtr)UMovieSceneCapture.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneCaptureSettings.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCapture.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008354 RID: 33620
		// (get) Token: 0x06021FBB RID: 139195 RVA: 0x003240FE File Offset: 0x003222FE
		// (set) Token: 0x06021FBC RID: 139196 RVA: 0x0032410E File Offset: 0x0032230E
		public unsafe bool bUseSeparateProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCapture.__PropertyOffset_bUseSeparateProcess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCapture.__PropertyOffset_bUseSeparateProcess) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008355 RID: 33621
		// (get) Token: 0x06021FBD RID: 139197 RVA: 0x0032411F File Offset: 0x0032231F
		// (set) Token: 0x06021FBE RID: 139198 RVA: 0x0032412F File Offset: 0x0032232F
		public unsafe bool bCloseEditorWhenCaptureStarts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCapture.__PropertyOffset_bCloseEditorWhenCaptureStarts) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCapture.__PropertyOffset_bCloseEditorWhenCaptureStarts) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008356 RID: 33622
		// (get) Token: 0x06021FBF RID: 139199 RVA: 0x00324140 File Offset: 0x00322340
		// (set) Token: 0x06021FC0 RID: 139200 RVA: 0x00324154 File Offset: 0x00322354
		public unsafe string AdditionalCommandLineArguments
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneCapture.__PropertyOffset_AdditionalCommandLineArguments)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneCapture.__PropertyOffset_AdditionalCommandLineArguments)), value);
			}
		}

		// Token: 0x17008357 RID: 33623
		// (get) Token: 0x06021FC1 RID: 139201 RVA: 0x00324169 File Offset: 0x00322369
		// (set) Token: 0x06021FC2 RID: 139202 RVA: 0x0032417D File Offset: 0x0032237D
		public unsafe string InheritedCommandLineArguments
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneCapture.__PropertyOffset_InheritedCommandLineArguments)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneCapture.__PropertyOffset_InheritedCommandLineArguments)), value);
			}
		}

		// Token: 0x06021FC3 RID: 139203 RVA: 0x00324192 File Offset: 0x00322392
		public void SetImageCaptureProtocolType([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMovieSceneCaptureProtocolBase> ProtocolType)
		{
			UMovieSceneCapture.__SetImageCaptureProtocolType_Internal(base.NativePtr, ProtocolType._NativePtr);
		}

		// Token: 0x06021FC4 RID: 139204 RVA: 0x003241A5 File Offset: 0x003223A5
		public void SetAudioCaptureProtocolType([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMovieSceneCaptureProtocolBase> ProtocolType)
		{
			UMovieSceneCapture.__SetAudioCaptureProtocolType_Internal(base.NativePtr, ProtocolType._NativePtr);
		}

		// Token: 0x06021FC5 RID: 139205 RVA: 0x003241B8 File Offset: 0x003223B8
		[NullableContext(2)]
		public UMovieSceneCaptureProtocolBase GetImageCaptureProtocol()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneCaptureProtocolBase>(UMovieSceneCapture.__GetImageCaptureProtocol_Internal(base.NativePtr));
		}

		// Token: 0x06021FC6 RID: 139206 RVA: 0x003241CA File Offset: 0x003223CA
		[NullableContext(2)]
		public UMovieSceneCaptureProtocolBase GetAudioCaptureProtocol()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneCaptureProtocolBase>(UMovieSceneCapture.__GetAudioCaptureProtocol_Internal(base.NativePtr));
		}

		// Token: 0x06021FC7 RID: 139207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetImageCaptureProtocolType_Internal(IntPtr @this, IntPtr ProtocolType);

		// Token: 0x06021FC8 RID: 139208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioCaptureProtocolType_Internal(IntPtr @this, IntPtr ProtocolType);

		// Token: 0x06021FC9 RID: 139209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetImageCaptureProtocol_Internal(IntPtr @this);

		// Token: 0x06021FCA RID: 139210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAudioCaptureProtocol_Internal(IntPtr @this);

		// Token: 0x06021FCB RID: 139211 RVA: 0x003241DC File Offset: 0x003223DC
		static UMovieSceneCapture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.MovieSceneCapture");
		}

		// Token: 0x06021FCC RID: 139212 RVA: 0x003241EA File Offset: 0x003223EA
		protected UMovieSceneCapture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012209 RID: 74249
		internal static int __InterfaceOffset_IMovieSceneCaptureInterface;

		// Token: 0x0401220A RID: 74250
		public new const string __ObjectPath = "/Script/MovieSceneCapture.MovieSceneCapture";

		// Token: 0x0401220B RID: 74251
		private static IntPtr _ClassPtr;

		// Token: 0x0401220C RID: 74252
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401220D RID: 74253
		internal static int __PropertyOffset_ImageCaptureProtocolType;

		// Token: 0x0401220E RID: 74254
		[Nullable(2)]
		private FSoftClassPath _ImageCaptureProtocolType;

		// Token: 0x0401220F RID: 74255
		internal static int __PropertyOffset_AudioCaptureProtocolType;

		// Token: 0x04012210 RID: 74256
		[Nullable(2)]
		private FSoftClassPath _AudioCaptureProtocolType;

		// Token: 0x04012211 RID: 74257
		internal static int __PropertyOffset_ImageCaptureProtocol;

		// Token: 0x04012212 RID: 74258
		internal static int __PropertyOffset_AudioCaptureProtocol;

		// Token: 0x04012213 RID: 74259
		internal static int __PropertyOffset_Settings;

		// Token: 0x04012214 RID: 74260
		[Nullable(2)]
		private FMovieSceneCaptureSettings _Settings;

		// Token: 0x04012215 RID: 74261
		internal static int __PropertyOffset_bUseSeparateProcess;

		// Token: 0x04012216 RID: 74262
		internal static int __PropertyOffset_bCloseEditorWhenCaptureStarts;

		// Token: 0x04012217 RID: 74263
		internal static int __PropertyOffset_AdditionalCommandLineArguments;

		// Token: 0x04012218 RID: 74264
		internal static int __PropertyOffset_InheritedCommandLineArguments;
	}
}
