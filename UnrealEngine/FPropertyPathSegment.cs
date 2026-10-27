using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002670 RID: 9840
	[UnrealObjectPath("/Script/PropertyPath.PropertyPathSegment")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FPropertyPathSegment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060248D3 RID: 149715 RVA: 0x00361C78 File Offset: 0x0035FE78
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropertyPathSegment._ScriptStructPtr != 0) ? FPropertyPathSegment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PropertyPath.PropertyPathSegment", ref FPropertyPathSegment._ScriptStructPtr);
		}

		// Token: 0x17008CE3 RID: 36067
		// (get) Token: 0x060248D4 RID: 149716 RVA: 0x00361C9C File Offset: 0x0035FE9C
		// (set) Token: 0x060248D5 RID: 149717 RVA: 0x00361CB0 File Offset: 0x0035FEB0
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyPathSegment.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyPathSegment.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008CE4 RID: 36068
		// (get) Token: 0x060248D6 RID: 149718 RVA: 0x00361CC5 File Offset: 0x0035FEC5
		// (set) Token: 0x060248D7 RID: 149719 RVA: 0x00361CD5 File Offset: 0x0035FED5
		public unsafe int ArrayIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyPathSegment.__PropertyOffset_ArrayIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyPathSegment.__PropertyOffset_ArrayIndex) = value;
			}
		}

		// Token: 0x17008CE5 RID: 36069
		// (get) Token: 0x060248D8 RID: 149720 RVA: 0x00361CE6 File Offset: 0x0035FEE6
		// (set) Token: 0x060248D9 RID: 149721 RVA: 0x00361CFA File Offset: 0x0035FEFA
		[Nullable(2)]
		public unsafe UStruct Struct
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStruct>(base.NativePtr / (IntPtr)sizeof(void*) + FPropertyPathSegment.__PropertyOffset_Struct);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPropertyPathSegment.__PropertyOffset_Struct, value);
			}
		}

		// Token: 0x060248DA RID: 149722 RVA: 0x00361D0F File Offset: 0x0035FF0F
		public FPropertyPathSegment()
		{
		}

		// Token: 0x060248DB RID: 149723 RVA: 0x00361D17 File Offset: 0x0035FF17
		[NullableContext(1)]
		public FPropertyPathSegment(FName Name, int ArrayIndex, UStruct Struct)
		{
			this.Name = Name;
			this.ArrayIndex = ArrayIndex;
			this.Struct = Struct;
		}

		// Token: 0x060248DC RID: 149724 RVA: 0x00361D34 File Offset: 0x0035FF34
		protected override IntPtr GetUStructPtr()
		{
			return FPropertyPathSegment.StaticStruct();
		}

		// Token: 0x060248DD RID: 149725 RVA: 0x00361D40 File Offset: 0x0035FF40
		[NullableContext(2)]
		public FPropertyPathSegment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060248DE RID: 149726 RVA: 0x00361D4A File Offset: 0x0035FF4A
		public FPropertyPathSegment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060248DF RID: 149727 RVA: 0x00361D55 File Offset: 0x0035FF55
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropertyPathSegment(Pointer, false, true);
		}

		// Token: 0x060248E0 RID: 149728 RVA: 0x00361D5F File Offset: 0x0035FF5F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropertyPathSegment(Pointer, MemoryOwner);
		}

		// Token: 0x04013A3F RID: 80447
		[Nullable(1)]
		public const string __ObjectPath = "/Script/PropertyPath.PropertyPathSegment";

		// Token: 0x04013A40 RID: 80448
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013A41 RID: 80449
		internal static int __PropertyOffset_Name;

		// Token: 0x04013A42 RID: 80450
		internal static int __PropertyOffset_ArrayIndex;

		// Token: 0x04013A43 RID: 80451
		internal static int __PropertyOffset_Struct;
	}
}
