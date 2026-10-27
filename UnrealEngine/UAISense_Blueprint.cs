using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000109 RID: 265
	[UnrealObjectPath("/Script/AIModule.AISense_Blueprint")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public abstract class UAISense_Blueprint : UAISense, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060013D4 RID: 5076 RVA: 0x0001D445 File Offset: 0x0001B645
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISense_Blueprint._ClassPtr;
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0001D451 File Offset: 0x0001B651
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x0001D465 File Offset: 0x0001B665
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UUserDefinedStruct> ListenerDataType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UAISense_Blueprint.__PropertyOffset_ListenerDataType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UAISense_Blueprint.__PropertyOffset_ListenerDataType) = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0001D47C File Offset: 0x0001B67C
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x0001D4B5 File Offset: 0x0001B6B5
		[Nullable(1)]
		public TArray<UAIPerceptionComponent> ListenerContainer
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAIPerceptionComponent> result;
				if ((result = this._ListenerContainer) == null)
				{
					result = (this._ListenerContainer = new TArray<UAIPerceptionComponent>(base.NativePtr + (IntPtr)UAISense_Blueprint.__PropertyOffset_ListenerContainer, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ListenerContainer.CopyAssign(value);
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x0001D4C4 File Offset: 0x0001B6C4
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x0001D4FD File Offset: 0x0001B6FD
		[Nullable(1)]
		public TArray<UAISenseEvent> UnprocessedEvents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAISenseEvent> result;
				if ((result = this._UnprocessedEvents) == null)
				{
					result = (this._UnprocessedEvents = new TArray<UAISenseEvent>(base.NativePtr + (IntPtr)UAISense_Blueprint.__PropertyOffset_UnprocessedEvents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UnprocessedEvents.CopyAssign(value);
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0001D50B File Offset: 0x0001B70B
		public virtual float OnUpdate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UAISenseEvent> EventsToProcess)
		{
			return UAISense_Blueprint.__OnUpdate_Internal(base.NativePtr, (EventsToProcess ?? new TArray<UAISenseEvent>()).NativePtr);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0001D528 File Offset: 0x0001B728
		[NullableContext(2)]
		public virtual void OnListenerUpdated(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
		{
			UAISense_Blueprint.__OnListenerUpdated_Internal(base.NativePtr, (ActorListener != null) ? ActorListener.NativePtr : IntPtr.Zero, (PerceptionComponent != null) ? PerceptionComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0001D555 File Offset: 0x0001B755
		[NullableContext(2)]
		public virtual void OnListenerUnregistered(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
		{
			UAISense_Blueprint.__OnListenerUnregistered_Internal(base.NativePtr, (ActorListener != null) ? ActorListener.NativePtr : IntPtr.Zero, (PerceptionComponent != null) ? PerceptionComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0001D582 File Offset: 0x0001B782
		[NullableContext(2)]
		public virtual void OnListenerRegistered(AActor ActorListener, UAIPerceptionComponent PerceptionComponent)
		{
			UAISense_Blueprint.__OnListenerRegistered_Internal(base.NativePtr, (ActorListener != null) ? ActorListener.NativePtr : IntPtr.Zero, (PerceptionComponent != null) ? PerceptionComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0001D5AF File Offset: 0x0001B7AF
		[NullableContext(2)]
		public virtual void K2_OnNewPawn(APawn NewPawn)
		{
			UAISense_Blueprint.__K2_OnNewPawn_Internal(base.NativePtr, (NewPawn != null) ? NewPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0001D5CC File Offset: 0x0001B7CC
		public void GetAllListenerComponents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAIPerceptionComponent> ListenerComponents)
		{
			UAISense_Blueprint.__GetAllListenerComponents_Internal(base.NativePtr, (ListenerComponents ?? new TArray<UAIPerceptionComponent>()).NativePtr);
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0001D5E9 File Offset: 0x0001B7E9
		public void GetAllListenerActors([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> ListenerActors)
		{
			UAISense_Blueprint.__GetAllListenerActors_Internal(base.NativePtr, (ListenerActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x060013E2 RID: 5090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __OnUpdate_Internal(IntPtr @this, IntPtr EventsToProcess);

		// Token: 0x060013E3 RID: 5091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnListenerUpdated_Internal(IntPtr @this, IntPtr ActorListener, IntPtr PerceptionComponent);

		// Token: 0x060013E4 RID: 5092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnListenerUnregistered_Internal(IntPtr @this, IntPtr ActorListener, IntPtr PerceptionComponent);

		// Token: 0x060013E5 RID: 5093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnListenerRegistered_Internal(IntPtr @this, IntPtr ActorListener, IntPtr PerceptionComponent);

		// Token: 0x060013E6 RID: 5094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnNewPawn_Internal(IntPtr @this, IntPtr NewPawn);

		// Token: 0x060013E7 RID: 5095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllListenerComponents_Internal(IntPtr @this, IntPtr ListenerComponents);

		// Token: 0x060013E8 RID: 5096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllListenerActors_Internal(IntPtr @this, IntPtr ListenerActors);

		// Token: 0x060013E9 RID: 5097 RVA: 0x0001D606 File Offset: 0x0001B806
		static UAISense_Blueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISense_Blueprint");
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0001D614 File Offset: 0x0001B814
		protected UAISense_Blueprint() : this(BuiltinUtils.AllocNativeUObject(UAISense_Blueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0001D63C File Offset: 0x0001B83C
		protected UAISense_Blueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003CC RID: 972
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISense_Blueprint";

		// Token: 0x040003CD RID: 973
		private static IntPtr _ClassPtr;

		// Token: 0x040003CE RID: 974
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003CF RID: 975
		internal static int __PropertyOffset_ListenerDataType;

		// Token: 0x040003D0 RID: 976
		internal static int __PropertyOffset_ListenerContainer;

		// Token: 0x040003D1 RID: 977
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAIPerceptionComponent> _ListenerContainer;

		// Token: 0x040003D2 RID: 978
		internal static int __PropertyOffset_UnprocessedEvents;

		// Token: 0x040003D3 RID: 979
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAISenseEvent> _UnprocessedEvents;

		// Token: 0x02002B43 RID: 11075
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnUpdate_FunctionParams
		{
			// Token: 0x040163A4 RID: 91044
			[FieldOffset(0)]
			public byte EventsToProcess;

			// Token: 0x040163A5 RID: 91045
			[FieldOffset(16)]
			public float __Result;
		}

		// Token: 0x02002B44 RID: 11076
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnListenerUpdated_FunctionParams
		{
			// Token: 0x040163A6 RID: 91046
			[FieldOffset(0)]
			public IntPtr ActorListener;

			// Token: 0x040163A7 RID: 91047
			[FieldOffset(8)]
			public IntPtr PerceptionComponent;
		}

		// Token: 0x02002B45 RID: 11077
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnListenerUnregistered_FunctionParams
		{
			// Token: 0x040163A8 RID: 91048
			[FieldOffset(0)]
			public IntPtr ActorListener;

			// Token: 0x040163A9 RID: 91049
			[FieldOffset(8)]
			public IntPtr PerceptionComponent;
		}

		// Token: 0x02002B46 RID: 11078
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnListenerRegistered_FunctionParams
		{
			// Token: 0x040163AA RID: 91050
			[FieldOffset(0)]
			public IntPtr ActorListener;

			// Token: 0x040163AB RID: 91051
			[FieldOffset(8)]
			public IntPtr PerceptionComponent;
		}

		// Token: 0x02002B47 RID: 11079
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnNewPawn_FunctionParams
		{
			// Token: 0x040163AC RID: 91052
			[FieldOffset(0)]
			public IntPtr NewPawn;
		}
	}
}
