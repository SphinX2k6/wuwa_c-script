using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017ED RID: 6125
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxy")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AKuroCrowdAiBoidInstanceSequenceProxy : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016A27 RID: 92711 RVA: 0x002104C1 File Offset: 0x0020E6C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCrowdAiBoidInstanceSequenceProxy._ClassPtr;
		}

		// Token: 0x06016A28 RID: 92712 RVA: 0x002104D0 File Offset: 0x0020E6D0
		public AKuroCrowdAiBoidInstanceSequenceProxy() : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidInstanceSequenceProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016A29 RID: 92713 RVA: 0x002104F8 File Offset: 0x0020E6F8
		[NullableContext(1)]
		public AKuroCrowdAiBoidInstanceSequenceProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidInstanceSequenceProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B88 RID: 23432
		// (get) Token: 0x06016A2A RID: 92714 RVA: 0x0021052B File Offset: 0x0020E72B
		// (set) Token: 0x06016A2B RID: 92715 RVA: 0x0021053F File Offset: 0x0020E73F
		[Nullable(2)]
		public unsafe USceneComponent RootSceneComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCrowdAiBoidInstanceSequenceProxy.__PropertyOffset_RootSceneComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCrowdAiBoidInstanceSequenceProxy.__PropertyOffset_RootSceneComponent, value);
			}
		}

		// Token: 0x06016A2C RID: 92716 RVA: 0x00210554 File Offset: 0x0020E754
		public void StopAnimation(int AnimationIndex, bool bImmediately)
		{
			AKuroCrowdAiBoidInstanceSequenceProxy.__StopAnimation_Internal(base.NativePtr, AnimationIndex, bImmediately);
		}

		// Token: 0x06016A2D RID: 92717 RVA: 0x00210563 File Offset: 0x0020E763
		public void PlayAnimation(int AnimationIndex, float PlayRate, float StartPos, bool bIsLoop)
		{
			AKuroCrowdAiBoidInstanceSequenceProxy.__PlayAnimation_Internal(base.NativePtr, AnimationIndex, PlayRate, StartPos, bIsLoop);
		}

		// Token: 0x06016A2E RID: 92718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAnimation_Internal(IntPtr @this, int AnimationIndex, bool bImmediately);

		// Token: 0x06016A2F RID: 92719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAnimation_Internal(IntPtr @this, int AnimationIndex, float PlayRate, float StartPos, bool bIsLoop);

		// Token: 0x06016A30 RID: 92720 RVA: 0x00210575 File Offset: 0x0020E775
		static AKuroCrowdAiBoidInstanceSequenceProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxy");
		}

		// Token: 0x06016A31 RID: 92721 RVA: 0x00210583 File Offset: 0x0020E783
		protected AKuroCrowdAiBoidInstanceSequenceProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C4A8 RID: 50344
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxy";

		// Token: 0x0400C4A9 RID: 50345
		private static IntPtr _ClassPtr;

		// Token: 0x0400C4AA RID: 50346
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C4AB RID: 50347
		internal static int __PropertyOffset_RootSceneComponent;
	}
}
