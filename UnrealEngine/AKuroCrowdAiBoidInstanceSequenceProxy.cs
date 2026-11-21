using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200035A RID: 858
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxy")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AKuroCrowdAiBoidInstanceSequenceProxy : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060057CF RID: 22479 RVA: 0x0007B8C1 File Offset: 0x00079AC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCrowdAiBoidInstanceSequenceProxy._ClassPtr;
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x0007B8D0 File Offset: 0x00079AD0
		public AKuroCrowdAiBoidInstanceSequenceProxy() : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidInstanceSequenceProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x0007B8F8 File Offset: 0x00079AF8
		[NullableContext(1)]
		public AKuroCrowdAiBoidInstanceSequenceProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidInstanceSequenceProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x060057D2 RID: 22482 RVA: 0x0007B92B File Offset: 0x00079B2B
		// (set) Token: 0x060057D3 RID: 22483 RVA: 0x0007B93F File Offset: 0x00079B3F
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

		// Token: 0x060057D4 RID: 22484 RVA: 0x0007B954 File Offset: 0x00079B54
		public void StopAnimation(int AnimationIndex, bool bImmediately)
		{
			AKuroCrowdAiBoidInstanceSequenceProxy.__StopAnimation_Internal(base.NativePtr, AnimationIndex, bImmediately);
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x0007B963 File Offset: 0x00079B63
		public void PlayAnimation(int AnimationIndex, float PlayRate, float StartPos, bool bIsLoop)
		{
			AKuroCrowdAiBoidInstanceSequenceProxy.__PlayAnimation_Internal(base.NativePtr, AnimationIndex, PlayRate, StartPos, bIsLoop);
		}

		// Token: 0x060057D6 RID: 22486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAnimation_Internal(IntPtr @this, int AnimationIndex, bool bImmediately);

		// Token: 0x060057D7 RID: 22487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAnimation_Internal(IntPtr @this, int AnimationIndex, float PlayRate, float StartPos, bool bIsLoop);

		// Token: 0x060057D8 RID: 22488 RVA: 0x0007B975 File Offset: 0x00079B75
		static AKuroCrowdAiBoidInstanceSequenceProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxy");
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x0007B983 File Offset: 0x00079B83
		protected AKuroCrowdAiBoidInstanceSequenceProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002435 RID: 9269
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxy";

		// Token: 0x04002436 RID: 9270
		private static IntPtr _ClassPtr;

		// Token: 0x04002437 RID: 9271
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002438 RID: 9272
		internal static int __PropertyOffset_RootSceneComponent;
	}
}
