using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BD1 RID: 3025
	[UnrealObjectPath("/Script/Engine.FastArraySerializer")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FFastArraySerializer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060094B8 RID: 38072 RVA: 0x000D447C File Offset: 0x000D267C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFastArraySerializer._ScriptStructPtr != 0) ? FFastArraySerializer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FastArraySerializer", ref FFastArraySerializer._ScriptStructPtr);
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x060094B9 RID: 38073 RVA: 0x000D44A0 File Offset: 0x000D26A0
		// (set) Token: 0x060094BA RID: 38074 RVA: 0x000D44B0 File Offset: 0x000D26B0
		public unsafe int ArrayReplicationKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFastArraySerializer.__PropertyOffset_ArrayReplicationKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFastArraySerializer.__PropertyOffset_ArrayReplicationKey) = value;
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x060094BB RID: 38075 RVA: 0x000D44C1 File Offset: 0x000D26C1
		// (set) Token: 0x060094BC RID: 38076 RVA: 0x000D44D1 File Offset: 0x000D26D1
		public unsafe EFastArraySerializerDeltaFlags DeltaFlags
		{
			get
			{
				return (EFastArraySerializerDeltaFlags)(*(base.NativePtr + (IntPtr)FFastArraySerializer.__PropertyOffset_DeltaFlags));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFastArraySerializer.__PropertyOffset_DeltaFlags) = (byte)value;
			}
		}

		// Token: 0x060094BD RID: 38077 RVA: 0x000D44E2 File Offset: 0x000D26E2
		public FFastArraySerializer()
		{
		}

		// Token: 0x060094BE RID: 38078 RVA: 0x000D44EA File Offset: 0x000D26EA
		public FFastArraySerializer(int ArrayReplicationKey, EFastArraySerializerDeltaFlags DeltaFlags)
		{
			this.ArrayReplicationKey = ArrayReplicationKey;
			this.DeltaFlags = DeltaFlags;
		}

		// Token: 0x060094BF RID: 38079 RVA: 0x000D4500 File Offset: 0x000D2700
		protected override IntPtr GetUStructPtr()
		{
			return FFastArraySerializer.StaticStruct();
		}

		// Token: 0x060094C0 RID: 38080 RVA: 0x000D450C File Offset: 0x000D270C
		[NullableContext(2)]
		public FFastArraySerializer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094C1 RID: 38081 RVA: 0x000D4516 File Offset: 0x000D2716
		public FFastArraySerializer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x000D4521 File Offset: 0x000D2721
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFastArraySerializer(Pointer, false, true);
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x000D452B File Offset: 0x000D272B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFastArraySerializer(Pointer, MemoryOwner);
		}

		// Token: 0x04005388 RID: 21384
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FastArraySerializer";

		// Token: 0x04005389 RID: 21385
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400538A RID: 21386
		internal static int __PropertyOffset_ArrayReplicationKey;

		// Token: 0x0400538B RID: 21387
		internal static int __PropertyOffset_DeltaFlags;
	}
}
