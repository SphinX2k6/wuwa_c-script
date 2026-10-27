using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002905 RID: 10501
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TemplateSequence.SequenceCameraShakeSequencePlayer")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class USequenceCameraShakeSequencePlayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F38 RID: 159544 RVA: 0x003B683B File Offset: 0x003B4A3B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USequenceCameraShakeSequencePlayer._ClassPtr;
		}

		// Token: 0x06026F39 RID: 159545 RVA: 0x003B6848 File Offset: 0x003B4A48
		public USequenceCameraShakeSequencePlayer() : this(BuiltinUtils.AllocNativeUObject(USequenceCameraShakeSequencePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F3A RID: 159546 RVA: 0x003B6870 File Offset: 0x003B4A70
		[NullableContext(1)]
		public USequenceCameraShakeSequencePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USequenceCameraShakeSequencePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009601 RID: 38401
		// (get) Token: 0x06026F3B RID: 159547 RVA: 0x003B68A3 File Offset: 0x003B4AA3
		// (set) Token: 0x06026F3C RID: 159548 RVA: 0x003B68B7 File Offset: 0x003B4AB7
		public unsafe UObject BoundObjectOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + USequenceCameraShakeSequencePlayer.__PropertyOffset_BoundObjectOverride);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USequenceCameraShakeSequencePlayer.__PropertyOffset_BoundObjectOverride, value);
			}
		}

		// Token: 0x17009602 RID: 38402
		// (get) Token: 0x06026F3D RID: 159549 RVA: 0x003B68CC File Offset: 0x003B4ACC
		// (set) Token: 0x06026F3E RID: 159550 RVA: 0x003B68E0 File Offset: 0x003B4AE0
		public unsafe UMovieSceneSequence Sequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSequence>(base.NativePtr / (IntPtr)sizeof(void*) + USequenceCameraShakeSequencePlayer.__PropertyOffset_Sequence);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USequenceCameraShakeSequencePlayer.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x17009603 RID: 38403
		// (get) Token: 0x06026F3F RID: 159551 RVA: 0x003B68F8 File Offset: 0x003B4AF8
		// (set) Token: 0x06026F40 RID: 159552 RVA: 0x003B6931 File Offset: 0x003B4B31
		[Nullable(1)]
		public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovieSceneRootEvaluationTemplateInstance result;
				if ((result = this._RootTemplateInstance) == null)
				{
					result = (this._RootTemplateInstance = new FMovieSceneRootEvaluationTemplateInstance(base.NativePtr + (IntPtr)USequenceCameraShakeSequencePlayer.__PropertyOffset_RootTemplateInstance, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneRootEvaluationTemplateInstance.StaticStruct(), base.NativePtr + (IntPtr)USequenceCameraShakeSequencePlayer.__PropertyOffset_RootTemplateInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026F41 RID: 159553 RVA: 0x003B6952 File Offset: 0x003B4B52
		static USequenceCameraShakeSequencePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TemplateSequence.SequenceCameraShakeSequencePlayer");
		}

		// Token: 0x06026F42 RID: 159554 RVA: 0x003B6960 File Offset: 0x003B4B60
		protected USequenceCameraShakeSequencePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015609 RID: 87561
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TemplateSequence.SequenceCameraShakeSequencePlayer";

		// Token: 0x0401560A RID: 87562
		private static IntPtr _ClassPtr;

		// Token: 0x0401560B RID: 87563
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401560C RID: 87564
		internal static int __PropertyOffset_BoundObjectOverride;

		// Token: 0x0401560D RID: 87565
		internal static int __PropertyOffset_Sequence;

		// Token: 0x0401560E RID: 87566
		internal static int __PropertyOffset_RootTemplateInstance;

		// Token: 0x0401560F RID: 87567
		private FMovieSceneRootEvaluationTemplateInstance _RootTemplateInstance;
	}
}
