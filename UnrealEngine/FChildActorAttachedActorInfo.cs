using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200092F RID: 2351
	[UnrealObjectPath("/Script/Engine.ChildActorAttachedActorInfo")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FChildActorAttachedActorInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060084E1 RID: 34017 RVA: 0x000BD869 File Offset: 0x000BBA69
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChildActorAttachedActorInfo._ScriptStructPtr != 0) ? FChildActorAttachedActorInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ChildActorAttachedActorInfo", ref FChildActorAttachedActorInfo._ScriptStructPtr);
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x060084E2 RID: 34018 RVA: 0x000BD88D File Offset: 0x000BBA8D
		// (set) Token: 0x060084E3 RID: 34019 RVA: 0x000BD8A1 File Offset: 0x000BBAA1
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> Actor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FChildActorAttachedActorInfo.__PropertyOffset_Actor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FChildActorAttachedActorInfo.__PropertyOffset_Actor) = value;
			}
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x060084E4 RID: 34020 RVA: 0x000BD8B6 File Offset: 0x000BBAB6
		// (set) Token: 0x060084E5 RID: 34021 RVA: 0x000BD8CA File Offset: 0x000BBACA
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChildActorAttachedActorInfo.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChildActorAttachedActorInfo.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x060084E6 RID: 34022 RVA: 0x000BD8DF File Offset: 0x000BBADF
		// (set) Token: 0x060084E7 RID: 34023 RVA: 0x000BD8F3 File Offset: 0x000BBAF3
		public unsafe FTransform RelativeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChildActorAttachedActorInfo.__PropertyOffset_RelativeTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChildActorAttachedActorInfo.__PropertyOffset_RelativeTransform) = value;
			}
		}

		// Token: 0x060084E8 RID: 34024 RVA: 0x000BD908 File Offset: 0x000BBB08
		public FChildActorAttachedActorInfo()
		{
		}

		// Token: 0x060084E9 RID: 34025 RVA: 0x000BD910 File Offset: 0x000BBB10
		public FChildActorAttachedActorInfo([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> Actor, FName SocketName, FTransform RelativeTransform)
		{
			this.Actor = Actor;
			this.SocketName = SocketName;
			this.RelativeTransform = RelativeTransform;
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x000BD92D File Offset: 0x000BBB2D
		protected override IntPtr GetUStructPtr()
		{
			return FChildActorAttachedActorInfo.StaticStruct();
		}

		// Token: 0x060084EB RID: 34027 RVA: 0x000BD939 File Offset: 0x000BBB39
		[NullableContext(2)]
		public FChildActorAttachedActorInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060084EC RID: 34028 RVA: 0x000BD943 File Offset: 0x000BBB43
		public FChildActorAttachedActorInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x000BD94E File Offset: 0x000BBB4E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChildActorAttachedActorInfo(Pointer, false, true);
		}

		// Token: 0x060084EE RID: 34030 RVA: 0x000BD958 File Offset: 0x000BBB58
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChildActorAttachedActorInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003F3E RID: 16190
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ChildActorAttachedActorInfo";

		// Token: 0x04003F3F RID: 16191
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003F40 RID: 16192
		internal static int __PropertyOffset_Actor;

		// Token: 0x04003F41 RID: 16193
		internal static int __PropertyOffset_SocketName;

		// Token: 0x04003F42 RID: 16194
		internal static int __PropertyOffset_RelativeTransform;
	}
}
