using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019B4 RID: 6580
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelStateMachine")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroLevelStateMachine : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060187A5 RID: 100261 RVA: 0x0024119B File Offset: 0x0023F39B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroLevelStateMachine._ClassPtr;
		}

		// Token: 0x060187A6 RID: 100262 RVA: 0x002411A8 File Offset: 0x0023F3A8
		public AKuroLevelStateMachine() : this(BuiltinUtils.AllocNativeUObject(AKuroLevelStateMachine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060187A7 RID: 100263 RVA: 0x002411D0 File Offset: 0x0023F3D0
		[NullableContext(1)]
		public AKuroLevelStateMachine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroLevelStateMachine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061BE RID: 25022
		// (get) Token: 0x060187A8 RID: 100264 RVA: 0x00241203 File Offset: 0x0023F403
		// (set) Token: 0x060187A9 RID: 100265 RVA: 0x00241217 File Offset: 0x0023F417
		[Nullable(2)]
		public unsafe UKuroLevelStateMachineComponent LevelStateMachineComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroLevelStateMachineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLevelStateMachine.__PropertyOffset_LevelStateMachineComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLevelStateMachine.__PropertyOffset_LevelStateMachineComponent, value);
			}
		}

		// Token: 0x060187AA RID: 100266 RVA: 0x0024122C File Offset: 0x0023F42C
		static AKuroLevelStateMachine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroLevelStateMachine.KuroLevelStateMachine");
		}

		// Token: 0x060187AB RID: 100267 RVA: 0x0024123A File Offset: 0x0023F43A
		protected AKuroLevelStateMachine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D391 RID: 54161
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelStateMachine";

		// Token: 0x0400D392 RID: 54162
		private static IntPtr _ClassPtr;

		// Token: 0x0400D393 RID: 54163
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D394 RID: 54164
		internal static int __PropertyOffset_LevelStateMachineComponent;
	}
}
