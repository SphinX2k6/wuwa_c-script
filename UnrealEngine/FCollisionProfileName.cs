using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000945 RID: 2373
	[UnrealObjectPath("/Script/Engine.CollisionProfileName")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FCollisionProfileName : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008624 RID: 34340 RVA: 0x000BF312 File Offset: 0x000BD512
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionProfileName._ScriptStructPtr != 0) ? FCollisionProfileName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollisionProfileName", ref FCollisionProfileName._ScriptStructPtr);
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x06008625 RID: 34341 RVA: 0x000BF336 File Offset: 0x000BD536
		// (set) Token: 0x06008626 RID: 34342 RVA: 0x000BF34A File Offset: 0x000BD54A
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionProfileName.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionProfileName.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x06008627 RID: 34343 RVA: 0x000BF35F File Offset: 0x000BD55F
		public FCollisionProfileName()
		{
		}

		// Token: 0x06008628 RID: 34344 RVA: 0x000BF367 File Offset: 0x000BD567
		public FCollisionProfileName(FName Name)
		{
			this.Name = Name;
		}

		// Token: 0x06008629 RID: 34345 RVA: 0x000BF376 File Offset: 0x000BD576
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionProfileName.StaticStruct();
		}

		// Token: 0x0600862A RID: 34346 RVA: 0x000BF382 File Offset: 0x000BD582
		[NullableContext(2)]
		public FCollisionProfileName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600862B RID: 34347 RVA: 0x000BF38C File Offset: 0x000BD58C
		public FCollisionProfileName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600862C RID: 34348 RVA: 0x000BF397 File Offset: 0x000BD597
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionProfileName(Pointer, false, true);
		}

		// Token: 0x0600862D RID: 34349 RVA: 0x000BF3A1 File Offset: 0x000BD5A1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionProfileName(Pointer, MemoryOwner);
		}

		// Token: 0x04003FD3 RID: 16339
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CollisionProfileName";

		// Token: 0x04003FD4 RID: 16340
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003FD5 RID: 16341
		internal static int __PropertyOffset_Name;
	}
}
