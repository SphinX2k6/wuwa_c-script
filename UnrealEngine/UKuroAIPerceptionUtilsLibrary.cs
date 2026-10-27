using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018BE RID: 6334
	[UnrealObjectPath("/Script/KuroGameplay.KuroAIPerceptionUtilsLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAIPerceptionUtilsLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017689 RID: 95881 RVA: 0x00223A52 File Offset: 0x00221C52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAIPerceptionUtilsLibrary._ClassPtr;
		}

		// Token: 0x0601768A RID: 95882 RVA: 0x00223A60 File Offset: 0x00221C60
		public UKuroAIPerceptionUtilsLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAIPerceptionUtilsLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601768B RID: 95883 RVA: 0x00223A88 File Offset: 0x00221C88
		[NullableContext(1)]
		public UKuroAIPerceptionUtilsLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAIPerceptionUtilsLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601768C RID: 95884 RVA: 0x00223ABB File Offset: 0x00221CBB
		[NullableContext(2)]
		public static void StartAsyncAiPerception(in FAIAsyncPerceptionCallback Callback, int DataId, double NowTime, UTraceLineElement LineElement)
		{
			FAIAsyncPerceptionCallback faiasyncPerceptionCallback = Callback;
			UKuroAIPerceptionUtilsLibrary.__StartAsyncAiPerception_Internal((faiasyncPerceptionCallback != null) ? faiasyncPerceptionCallback.NativePtr : ((IntPtr)0), DataId, NowTime, (LineElement != null) ? LineElement.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601768D RID: 95885 RVA: 0x00223AE4 File Offset: 0x00221CE4
		[NullableContext(2)]
		public static void Initialize(in TArray<FName> EntityTypeQueryNames, int EEntityTypeQueryCharacter, int EEntityTypeQuerySceneItem, int EEntityTypeQueryMaxIndex, int ECharMoveStateOther, int ECharMoveStateStand, int ECharMoveStateWalk, int ECharMoveStateWalkStop, int ECharMoveStateGlide, int ECharPositionStateGround, int ESenseTargetTypeCharacter)
		{
			UKuroAIPerceptionUtilsLibrary.__Initialize_Internal((EntityTypeQueryNames ?? new TArray<FName>()).NativePtr, EEntityTypeQueryCharacter, EEntityTypeQuerySceneItem, EEntityTypeQueryMaxIndex, ECharMoveStateOther, ECharMoveStateStand, ECharMoveStateWalk, ECharMoveStateWalkStop, ECharMoveStateGlide, ECharPositionStateGround, ESenseTargetTypeCharacter);
		}

		// Token: 0x0601768E RID: 95886
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();

		// Token: 0x0601768F RID: 95887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartAsyncAiPerception_Internal(IntPtr Callback, int DataId, double NowTime, IntPtr LineElement);

		// Token: 0x06017690 RID: 95888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr EntityTypeQueryNames, int EEntityTypeQueryCharacter, int EEntityTypeQuerySceneItem, int EEntityTypeQueryMaxIndex, int ECharMoveStateOther, int ECharMoveStateStand, int ECharMoveStateWalk, int ECharMoveStateWalkStop, int ECharMoveStateGlide, int ECharPositionStateGround, int ESenseTargetTypeCharacter);

		// Token: 0x06017691 RID: 95889 RVA: 0x00223B17 File Offset: 0x00221D17
		static UKuroAIPerceptionUtilsLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroAIPerceptionUtilsLibrary");
		}

		// Token: 0x06017692 RID: 95890 RVA: 0x00223B25 File Offset: 0x00221D25
		protected UKuroAIPerceptionUtilsLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CBB7 RID: 52151
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroAIPerceptionUtilsLibrary";

		// Token: 0x0400CBB8 RID: 52152
		private static IntPtr _ClassPtr;

		// Token: 0x0400CBB9 RID: 52153
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
