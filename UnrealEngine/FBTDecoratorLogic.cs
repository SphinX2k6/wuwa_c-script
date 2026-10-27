using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000139 RID: 313
	[UnrealObjectPath("/Script/AIModule.BTDecoratorLogic")]
	[UnrealStructLayout(4, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FBTDecoratorLogic : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060015F8 RID: 5624 RVA: 0x000204A1 File Offset: 0x0001E6A1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBTDecoratorLogic._ScriptStructPtr != 0) ? FBTDecoratorLogic._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.BTDecoratorLogic", ref FBTDecoratorLogic._ScriptStructPtr);
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x000204C5 File Offset: 0x0001E6C5
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x000204D9 File Offset: 0x0001E6D9
		public unsafe TEnumAsByte<EBTDecoratorLogic> Operation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBTDecoratorLogic.__PropertyOffset_Operation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBTDecoratorLogic.__PropertyOffset_Operation) = value;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x000204EE File Offset: 0x0001E6EE
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x000204FE File Offset: 0x0001E6FE
		public unsafe ushort Number
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBTDecoratorLogic.__PropertyOffset_Number);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBTDecoratorLogic.__PropertyOffset_Number) = (short)value;
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0002050F File Offset: 0x0001E70F
		public FBTDecoratorLogic()
		{
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00020517 File Offset: 0x0001E717
		public FBTDecoratorLogic(TEnumAsByte<EBTDecoratorLogic> Operation, ushort Number)
		{
			this.Operation = Operation;
			this.Number = Number;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0002052D File Offset: 0x0001E72D
		protected override IntPtr GetUStructPtr()
		{
			return FBTDecoratorLogic.StaticStruct();
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00020539 File Offset: 0x0001E739
		[NullableContext(2)]
		public FBTDecoratorLogic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00020543 File Offset: 0x0001E743
		public FBTDecoratorLogic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0002054E File Offset: 0x0001E74E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBTDecoratorLogic(Pointer, false, true);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00020558 File Offset: 0x0001E758
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBTDecoratorLogic(Pointer, MemoryOwner);
		}

		// Token: 0x040004D9 RID: 1241
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.BTDecoratorLogic";

		// Token: 0x040004DA RID: 1242
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040004DB RID: 1243
		internal static int __PropertyOffset_Operation;

		// Token: 0x040004DC RID: 1244
		internal static int __PropertyOffset_Number;
	}
}
