using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C2D RID: 7213
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.SplitTextureStreamerDebugActor")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class ASplitTextureStreamerDebugActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BEC1 RID: 114369 RVA: 0x0029163B File Offset: 0x0028F83B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASplitTextureStreamerDebugActor._ClassPtr;
		}

		// Token: 0x0601BEC2 RID: 114370 RVA: 0x00291648 File Offset: 0x0028F848
		public ASplitTextureStreamerDebugActor() : this(BuiltinUtils.AllocNativeUObject(ASplitTextureStreamerDebugActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BEC3 RID: 114371 RVA: 0x00291670 File Offset: 0x0028F870
		public ASplitTextureStreamerDebugActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASplitTextureStreamerDebugActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070B2 RID: 28850
		// (get) Token: 0x0601BEC4 RID: 114372 RVA: 0x002916A3 File Offset: 0x0028F8A3
		// (set) Token: 0x0601BEC5 RID: 114373 RVA: 0x002916B7 File Offset: 0x0028F8B7
		[Nullable(2)]
		public unsafe USceneComponent SceneComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASplitTextureStreamerDebugActor.__PropertyOffset_SceneComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASplitTextureStreamerDebugActor.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x170070B3 RID: 28851
		// (get) Token: 0x0601BEC6 RID: 114374 RVA: 0x002916CC File Offset: 0x0028F8CC
		// (set) Token: 0x0601BEC7 RID: 114375 RVA: 0x002916E0 File Offset: 0x0028F8E0
		[Nullable(2)]
		public unsafe UKuroSplitTextureStreamerSettings StreamerSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSplitTextureStreamerSettings>(base.NativePtr / (IntPtr)sizeof(void*) + ASplitTextureStreamerDebugActor.__PropertyOffset_StreamerSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASplitTextureStreamerDebugActor.__PropertyOffset_StreamerSettings, value);
			}
		}

		// Token: 0x170070B4 RID: 28852
		// (get) Token: 0x0601BEC8 RID: 114376 RVA: 0x002916F5 File Offset: 0x0028F8F5
		// (set) Token: 0x0601BEC9 RID: 114377 RVA: 0x00291705 File Offset: 0x0028F905
		public unsafe int LoadNumPerSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ASplitTextureStreamerDebugActor.__PropertyOffset_LoadNumPerSide);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ASplitTextureStreamerDebugActor.__PropertyOffset_LoadNumPerSide) = value;
			}
		}

		// Token: 0x170070B5 RID: 28853
		// (get) Token: 0x0601BECA RID: 114378 RVA: 0x00291718 File Offset: 0x0028F918
		// (set) Token: 0x0601BECB RID: 114379 RVA: 0x00291751 File Offset: 0x0028F951
		public TArray<UObject> LoadedTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._LoadedTextures) == null)
				{
					result = (this._LoadedTextures = new TArray<UObject>(base.NativePtr + (IntPtr)ASplitTextureStreamerDebugActor.__PropertyOffset_LoadedTextures, this));
				}
				return result;
			}
			set
			{
				this.LoadedTextures.CopyAssign(value);
			}
		}

		// Token: 0x170070B6 RID: 28854
		// (get) Token: 0x0601BECC RID: 114380 RVA: 0x00291760 File Offset: 0x0028F960
		// (set) Token: 0x0601BECD RID: 114381 RVA: 0x00291799 File Offset: 0x0028F999
		public TArray<float> LoadedTexturesHeight
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LoadedTexturesHeight) == null)
				{
					result = (this._LoadedTexturesHeight = new TArray<float>(base.NativePtr + (IntPtr)ASplitTextureStreamerDebugActor.__PropertyOffset_LoadedTexturesHeight, this));
				}
				return result;
			}
			set
			{
				this.LoadedTexturesHeight.CopyAssign(value);
			}
		}

		// Token: 0x0601BECE RID: 114382 RVA: 0x002917A7 File Offset: 0x0028F9A7
		static ASplitTextureStreamerDebugActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.SplitTextureStreamerDebugActor");
		}

		// Token: 0x0601BECF RID: 114383 RVA: 0x002917B5 File Offset: 0x0028F9B5
		protected ASplitTextureStreamerDebugActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EFEA RID: 61418
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.SplitTextureStreamerDebugActor";

		// Token: 0x0400EFEB RID: 61419
		private static IntPtr _ClassPtr;

		// Token: 0x0400EFEC RID: 61420
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EFED RID: 61421
		internal static int __PropertyOffset_SceneComponent;

		// Token: 0x0400EFEE RID: 61422
		internal static int __PropertyOffset_StreamerSettings;

		// Token: 0x0400EFEF RID: 61423
		internal static int __PropertyOffset_LoadNumPerSide;

		// Token: 0x0400EFF0 RID: 61424
		internal static int __PropertyOffset_LoadedTextures;

		// Token: 0x0400EFF1 RID: 61425
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _LoadedTextures;

		// Token: 0x0400EFF2 RID: 61426
		internal static int __PropertyOffset_LoadedTexturesHeight;

		// Token: 0x0400EFF3 RID: 61427
		[Nullable(2)]
		private TArray<float> _LoadedTexturesHeight;
	}
}
