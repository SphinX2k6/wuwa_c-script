using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029E6 RID: 10726
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.UMGSequencePlayer")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class UUMGSequencePlayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027BC9 RID: 162761 RVA: 0x003C931D File Offset: 0x003C751D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUMGSequencePlayer._ClassPtr;
		}

		// Token: 0x06027BCA RID: 162762 RVA: 0x003C932C File Offset: 0x003C752C
		public UUMGSequencePlayer() : this(BuiltinUtils.AllocNativeUObject(UUMGSequencePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027BCB RID: 162763 RVA: 0x003C9354 File Offset: 0x003C7554
		public UUMGSequencePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUMGSequencePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700983C RID: 38972
		// (get) Token: 0x06027BCC RID: 162764 RVA: 0x003C9387 File Offset: 0x003C7587
		// (set) Token: 0x06027BCD RID: 162765 RVA: 0x003C939B File Offset: 0x003C759B
		[Nullable(2)]
		public unsafe UWidgetAnimation Animation
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetAnimation>(base.NativePtr / (IntPtr)sizeof(void*) + UUMGSequencePlayer.__PropertyOffset_Animation);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUMGSequencePlayer.__PropertyOffset_Animation, value);
			}
		}

		// Token: 0x1700983D RID: 38973
		// (get) Token: 0x06027BCE RID: 162766 RVA: 0x003C93B0 File Offset: 0x003C75B0
		// (set) Token: 0x06027BCF RID: 162767 RVA: 0x003C93E9 File Offset: 0x003C75E9
		public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneRootEvaluationTemplateInstance result;
				if ((result = this._RootTemplateInstance) == null)
				{
					result = (this._RootTemplateInstance = new FMovieSceneRootEvaluationTemplateInstance(base.NativePtr + (IntPtr)UUMGSequencePlayer.__PropertyOffset_RootTemplateInstance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneRootEvaluationTemplateInstance.StaticStruct(), base.NativePtr + (IntPtr)UUMGSequencePlayer.__PropertyOffset_RootTemplateInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027BD0 RID: 162768 RVA: 0x003C940A File Offset: 0x003C760A
		public void SetUserTag(FName InUserTag)
		{
			UUMGSequencePlayer.__SetUserTag_Internal(base.NativePtr, InUserTag);
		}

		// Token: 0x06027BD1 RID: 162769 RVA: 0x003C9418 File Offset: 0x003C7618
		public FName GetUserTag()
		{
			return UUMGSequencePlayer.__GetUserTag_Internal(base.NativePtr);
		}

		// Token: 0x06027BD2 RID: 162770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserTag_Internal(IntPtr @this, FName InUserTag);

		// Token: 0x06027BD3 RID: 162771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetUserTag_Internal(IntPtr @this);

		// Token: 0x06027BD4 RID: 162772 RVA: 0x003C9425 File Offset: 0x003C7625
		static UUMGSequencePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.UMGSequencePlayer");
		}

		// Token: 0x06027BD5 RID: 162773 RVA: 0x003C9433 File Offset: 0x003C7633
		protected UUMGSequencePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C18 RID: 89112
		public new const string __ObjectPath = "/Script/UMG.UMGSequencePlayer";

		// Token: 0x04015C19 RID: 89113
		private static IntPtr _ClassPtr;

		// Token: 0x04015C1A RID: 89114
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C1B RID: 89115
		internal static int __PropertyOffset_Animation;

		// Token: 0x04015C1C RID: 89116
		internal static int __PropertyOffset_RootTemplateInstance;

		// Token: 0x04015C1D RID: 89117
		[Nullable(2)]
		private FMovieSceneRootEvaluationTemplateInstance _RootTemplateInstance;
	}
}
