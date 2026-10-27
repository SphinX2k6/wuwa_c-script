using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200266A RID: 9834
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PropertyAccess.PropertyAccessSegment")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FPropertyAccessSegment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060248B1 RID: 149681 RVA: 0x00361A14 File Offset: 0x0035FC14
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropertyAccessSegment._ScriptStructPtr != 0) ? FPropertyAccessSegment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PropertyAccess.PropertyAccessSegment", ref FPropertyAccessSegment._ScriptStructPtr);
		}

		// Token: 0x17008CDB RID: 36059
		// (get) Token: 0x060248B2 RID: 149682 RVA: 0x00361A38 File Offset: 0x0035FC38
		// (set) Token: 0x060248B3 RID: 149683 RVA: 0x00361A4C File Offset: 0x0035FC4C
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessSegment.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessSegment.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008CDC RID: 36060
		// (get) Token: 0x060248B4 RID: 149684 RVA: 0x00361A61 File Offset: 0x0035FC61
		// (set) Token: 0x060248B5 RID: 149685 RVA: 0x00361A75 File Offset: 0x0035FC75
		[Nullable(2)]
		public unsafe UStruct Struct
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStruct>(base.NativePtr / (IntPtr)sizeof(void*) + FPropertyAccessSegment.__PropertyOffset_Struct);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPropertyAccessSegment.__PropertyOffset_Struct, value);
			}
		}

		// Token: 0x17008CDD RID: 36061
		// (get) Token: 0x060248B6 RID: 149686 RVA: 0x00361A8A File Offset: 0x0035FC8A
		// (set) Token: 0x060248B7 RID: 149687 RVA: 0x00361A9A File Offset: 0x0035FC9A
		public unsafe Unusable Property
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessSegment.__PropertyOffset_Property);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessSegment.__PropertyOffset_Property) = value;
			}
		}

		// Token: 0x17008CDE RID: 36062
		// (get) Token: 0x060248B8 RID: 149688 RVA: 0x00361AAB File Offset: 0x0035FCAB
		// (set) Token: 0x060248B9 RID: 149689 RVA: 0x00361ABF File Offset: 0x0035FCBF
		[Nullable(2)]
		public unsafe UFunction Function
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFunction>(base.NativePtr / (IntPtr)sizeof(void*) + FPropertyAccessSegment.__PropertyOffset_Function);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPropertyAccessSegment.__PropertyOffset_Function, value);
			}
		}

		// Token: 0x17008CDF RID: 36063
		// (get) Token: 0x060248BA RID: 149690 RVA: 0x00361AD4 File Offset: 0x0035FCD4
		// (set) Token: 0x060248BB RID: 149691 RVA: 0x00361AE4 File Offset: 0x0035FCE4
		public unsafe int ArrayIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessSegment.__PropertyOffset_ArrayIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessSegment.__PropertyOffset_ArrayIndex) = value;
			}
		}

		// Token: 0x17008CE0 RID: 36064
		// (get) Token: 0x060248BC RID: 149692 RVA: 0x00361AF5 File Offset: 0x0035FCF5
		// (set) Token: 0x060248BD RID: 149693 RVA: 0x00361B05 File Offset: 0x0035FD05
		public unsafe ushort Flags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessSegment.__PropertyOffset_Flags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessSegment.__PropertyOffset_Flags) = (short)value;
			}
		}

		// Token: 0x060248BE RID: 149694 RVA: 0x00361B16 File Offset: 0x0035FD16
		public FPropertyAccessSegment()
		{
		}

		// Token: 0x060248BF RID: 149695 RVA: 0x00361B1E File Offset: 0x0035FD1E
		public FPropertyAccessSegment(FName Name, UStruct Struct, Unusable Property, UFunction Function, int ArrayIndex, ushort Flags)
		{
			this.Name = Name;
			this.Struct = Struct;
			this.Property = Property;
			this.Function = Function;
			this.ArrayIndex = ArrayIndex;
			this.Flags = Flags;
		}

		// Token: 0x060248C0 RID: 149696 RVA: 0x00361B53 File Offset: 0x0035FD53
		protected override IntPtr GetUStructPtr()
		{
			return FPropertyAccessSegment.StaticStruct();
		}

		// Token: 0x060248C1 RID: 149697 RVA: 0x00361B5F File Offset: 0x0035FD5F
		[NullableContext(2)]
		public FPropertyAccessSegment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060248C2 RID: 149698 RVA: 0x00361B69 File Offset: 0x0035FD69
		public FPropertyAccessSegment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060248C3 RID: 149699 RVA: 0x00361B74 File Offset: 0x0035FD74
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropertyAccessSegment(Pointer, false, true);
		}

		// Token: 0x060248C4 RID: 149700 RVA: 0x00361B7E File Offset: 0x0035FD7E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropertyAccessSegment(Pointer, MemoryOwner);
		}

		// Token: 0x04013A28 RID: 80424
		public const string __ObjectPath = "/Script/PropertyAccess.PropertyAccessSegment";

		// Token: 0x04013A29 RID: 80425
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013A2A RID: 80426
		internal static int __PropertyOffset_Name;

		// Token: 0x04013A2B RID: 80427
		internal static int __PropertyOffset_Struct;

		// Token: 0x04013A2C RID: 80428
		internal static int __PropertyOffset_Property;

		// Token: 0x04013A2D RID: 80429
		internal static int __PropertyOffset_Function;

		// Token: 0x04013A2E RID: 80430
		internal static int __PropertyOffset_ArrayIndex;

		// Token: 0x04013A2F RID: 80431
		internal static int __PropertyOffset_Flags;
	}
}
