using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002907 RID: 10503
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TemplateSequence.TemplateSequenceActor")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class ATemplateSequenceActor : AActor, IUnrealUObject, IUnrealObject, IMovieScenePlaybackClient, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06026F50 RID: 159568 RVA: 0x003B6ACE File Offset: 0x003B4CCE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATemplateSequenceActor._ClassPtr;
		}

		// Token: 0x06026F51 RID: 159569 RVA: 0x003B6ADA File Offset: 0x003B4CDA
		int IMovieScenePlaybackClient.InterfaceOffset()
		{
			return ATemplateSequenceActor.__InterfaceOffset_IMovieScenePlaybackClient;
		}

		// Token: 0x06026F52 RID: 159570 RVA: 0x003B6AE4 File Offset: 0x003B4CE4
		public ATemplateSequenceActor() : this(BuiltinUtils.AllocNativeUObject(ATemplateSequenceActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F53 RID: 159571 RVA: 0x003B6B0C File Offset: 0x003B4D0C
		public ATemplateSequenceActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATemplateSequenceActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009608 RID: 38408
		// (get) Token: 0x06026F54 RID: 159572 RVA: 0x003B6B40 File Offset: 0x003B4D40
		// (set) Token: 0x06026F55 RID: 159573 RVA: 0x003B6B79 File Offset: 0x003B4D79
		public FMovieSceneSequencePlaybackSettings PlaybackSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequencePlaybackSettings result;
				if ((result = this._PlaybackSettings) == null)
				{
					result = (this._PlaybackSettings = new FMovieSceneSequencePlaybackSettings(base.NativePtr + (IntPtr)ATemplateSequenceActor.__PropertyOffset_PlaybackSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequencePlaybackSettings.StaticStruct(), base.NativePtr + (IntPtr)ATemplateSequenceActor.__PropertyOffset_PlaybackSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009609 RID: 38409
		// (get) Token: 0x06026F56 RID: 159574 RVA: 0x003B6B9A File Offset: 0x003B4D9A
		// (set) Token: 0x06026F57 RID: 159575 RVA: 0x003B6BAE File Offset: 0x003B4DAE
		[Nullable(2)]
		public unsafe UTemplateSequencePlayer SequencePlayer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTemplateSequencePlayer>(base.NativePtr / (IntPtr)sizeof(void*) + ATemplateSequenceActor.__PropertyOffset_SequencePlayer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATemplateSequenceActor.__PropertyOffset_SequencePlayer, value);
			}
		}

		// Token: 0x1700960A RID: 38410
		// (get) Token: 0x06026F58 RID: 159576 RVA: 0x003B6BC4 File Offset: 0x003B4DC4
		// (set) Token: 0x06026F59 RID: 159577 RVA: 0x003B6BFD File Offset: 0x003B4DFD
		public FSoftObjectPath TemplateSequence
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._TemplateSequence) == null)
				{
					result = (this._TemplateSequence = new FSoftObjectPath(base.NativePtr + (IntPtr)ATemplateSequenceActor.__PropertyOffset_TemplateSequence, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)ATemplateSequenceActor.__PropertyOffset_TemplateSequence, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700960B RID: 38411
		// (get) Token: 0x06026F5A RID: 159578 RVA: 0x003B6C20 File Offset: 0x003B4E20
		// (set) Token: 0x06026F5B RID: 159579 RVA: 0x003B6C59 File Offset: 0x003B4E59
		public FTemplateSequenceBindingOverrideData BindingOverride
		{
			get
			{
				base.FastCheckIsValid();
				FTemplateSequenceBindingOverrideData result;
				if ((result = this._BindingOverride) == null)
				{
					result = (this._BindingOverride = new FTemplateSequenceBindingOverrideData(base.NativePtr + (IntPtr)ATemplateSequenceActor.__PropertyOffset_BindingOverride, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTemplateSequenceBindingOverrideData.StaticStruct(), base.NativePtr + (IntPtr)ATemplateSequenceActor.__PropertyOffset_BindingOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026F5C RID: 159580 RVA: 0x003B6C7A File Offset: 0x003B4E7A
		[NullableContext(2)]
		public void SetSequence(UTemplateSequence InSequence)
		{
			ATemplateSequenceActor.__SetSequence_Internal(base.NativePtr, (InSequence != null) ? InSequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06026F5D RID: 159581 RVA: 0x003B6C97 File Offset: 0x003B4E97
		[NullableContext(2)]
		public void SetBinding(AActor Actor)
		{
			ATemplateSequenceActor.__SetBinding_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06026F5E RID: 159582 RVA: 0x003B6CB4 File Offset: 0x003B4EB4
		[NullableContext(2)]
		public UTemplateSequence LoadSequence()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTemplateSequence>(ATemplateSequenceActor.__LoadSequence_Internal(base.NativePtr));
		}

		// Token: 0x06026F5F RID: 159583 RVA: 0x003B6CC6 File Offset: 0x003B4EC6
		[NullableContext(2)]
		public UTemplateSequencePlayer GetSequencePlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTemplateSequencePlayer>(ATemplateSequenceActor.__GetSequencePlayer_Internal(base.NativePtr));
		}

		// Token: 0x06026F60 RID: 159584 RVA: 0x003B6CD8 File Offset: 0x003B4ED8
		[NullableContext(2)]
		public UTemplateSequence GetSequence()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTemplateSequence>(ATemplateSequenceActor.__GetSequence_Internal(base.NativePtr));
		}

		// Token: 0x06026F61 RID: 159585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSequence_Internal(IntPtr @this, IntPtr InSequence);

		// Token: 0x06026F62 RID: 159586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBinding_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x06026F63 RID: 159587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadSequence_Internal(IntPtr @this);

		// Token: 0x06026F64 RID: 159588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequencePlayer_Internal(IntPtr @this);

		// Token: 0x06026F65 RID: 159589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequence_Internal(IntPtr @this);

		// Token: 0x06026F66 RID: 159590 RVA: 0x003B6CEA File Offset: 0x003B4EEA
		static ATemplateSequenceActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TemplateSequence.TemplateSequenceActor");
		}

		// Token: 0x06026F67 RID: 159591 RVA: 0x003B6CF8 File Offset: 0x003B4EF8
		protected ATemplateSequenceActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015618 RID: 87576
		internal static int __InterfaceOffset_IMovieScenePlaybackClient;

		// Token: 0x04015619 RID: 87577
		public new const string __ObjectPath = "/Script/TemplateSequence.TemplateSequenceActor";

		// Token: 0x0401561A RID: 87578
		private static IntPtr _ClassPtr;

		// Token: 0x0401561B RID: 87579
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401561C RID: 87580
		internal static int __PropertyOffset_PlaybackSettings;

		// Token: 0x0401561D RID: 87581
		[Nullable(2)]
		private FMovieSceneSequencePlaybackSettings _PlaybackSettings;

		// Token: 0x0401561E RID: 87582
		internal static int __PropertyOffset_SequencePlayer;

		// Token: 0x0401561F RID: 87583
		internal static int __PropertyOffset_TemplateSequence;

		// Token: 0x04015620 RID: 87584
		[Nullable(2)]
		private FSoftObjectPath _TemplateSequence;

		// Token: 0x04015621 RID: 87585
		internal static int __PropertyOffset_BindingOverride;

		// Token: 0x04015622 RID: 87586
		[Nullable(2)]
		private FTemplateSequenceBindingOverrideData _BindingOverride;
	}
}
