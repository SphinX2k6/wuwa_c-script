using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003DB RID: 987
	[UnrealObjectPath("/Script/KuroGameplay.KuroAIPerceptionUtilsLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAIPerceptionUtilsLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006117 RID: 24855 RVA: 0x0008ABB2 File Offset: 0x00088DB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAIPerceptionUtilsLibrary._ClassPtr;
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x0008ABC0 File Offset: 0x00088DC0
		public UKuroAIPerceptionUtilsLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAIPerceptionUtilsLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x0008ABE8 File Offset: 0x00088DE8
		[NullableContext(1)]
		public UKuroAIPerceptionUtilsLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAIPerceptionUtilsLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x0008AC1B File Offset: 0x00088E1B
		[NullableContext(2)]
		public static void StartAsyncAiPerception(in FAIAsyncPerceptionCallback Callback, int DataId, double NowTime, UTraceLineElement LineElement)
		{
			FAIAsyncPerceptionCallback faiasyncPerceptionCallback = Callback;
			UKuroAIPerceptionUtilsLibrary.__StartAsyncAiPerception_Internal((faiasyncPerceptionCallback != null) ? faiasyncPerceptionCallback.NativePtr : ((IntPtr)0), DataId, NowTime, (LineElement != null) ? LineElement.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x0008AC44 File Offset: 0x00088E44
		[NullableContext(2)]
		public static void Initialize(in TArray<FName> EntityTypeQueryNames, int EEntityTypeQueryCharacter, int EEntityTypeQuerySceneItem, int EEntityTypeQueryMaxIndex, int ECharMoveStateOther, int ECharMoveStateStand, int ECharMoveStateWalk, int ECharMoveStateWalkStop, int ECharMoveStateGlide, int ECharPositionStateGround, int ESenseTargetTypeCharacter)
		{
			UKuroAIPerceptionUtilsLibrary.__Initialize_Internal((EntityTypeQueryNames ?? new TArray<FName>()).NativePtr, EEntityTypeQueryCharacter, EEntityTypeQuerySceneItem, EEntityTypeQueryMaxIndex, ECharMoveStateOther, ECharMoveStateStand, ECharMoveStateWalk, ECharMoveStateWalkStop, ECharMoveStateGlide, ECharPositionStateGround, ESenseTargetTypeCharacter);
		}

		// Token: 0x0600611C RID: 24860
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();

		// Token: 0x0600611D RID: 24861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartAsyncAiPerception_Internal(IntPtr Callback, int DataId, double NowTime, IntPtr LineElement);

		// Token: 0x0600611E RID: 24862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr EntityTypeQueryNames, int EEntityTypeQueryCharacter, int EEntityTypeQuerySceneItem, int EEntityTypeQueryMaxIndex, int ECharMoveStateOther, int ECharMoveStateStand, int ECharMoveStateWalk, int ECharMoveStateWalkStop, int ECharMoveStateGlide, int ECharPositionStateGround, int ESenseTargetTypeCharacter);

		// Token: 0x0600611F RID: 24863 RVA: 0x0008AC77 File Offset: 0x00088E77
		static UKuroAIPerceptionUtilsLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroAIPerceptionUtilsLibrary");
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x0008AC85 File Offset: 0x00088E85
		protected UKuroAIPerceptionUtilsLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002960 RID: 10592
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroAIPerceptionUtilsLibrary";

		// Token: 0x04002961 RID: 10593
		private static IntPtr _ClassPtr;

		// Token: 0x04002962 RID: 10594
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
