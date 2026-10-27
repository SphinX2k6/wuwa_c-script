using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B67 RID: 7015
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedColorGroup")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1648)]
	public class FKuroMaterialNamedColorGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A8DE RID: 108766 RVA: 0x002727B6 File Offset: 0x002709B6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialNamedColorGroup._ScriptStructPtr != 0) ? FKuroMaterialNamedColorGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedColorGroup", ref FKuroMaterialNamedColorGroup._ScriptStructPtr);
		}

		// Token: 0x17006AB7 RID: 27319
		// (get) Token: 0x0601A8DF RID: 108767 RVA: 0x002727DA File Offset: 0x002709DA
		// (set) Token: 0x0601A8E0 RID: 108768 RVA: 0x002727EE File Offset: 0x002709EE
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedColorGroup.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedColorGroup.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006AB8 RID: 27320
		// (get) Token: 0x0601A8E1 RID: 108769 RVA: 0x00272804 File Offset: 0x00270A04
		// (set) Token: 0x0601A8E2 RID: 108770 RVA: 0x00272847 File Offset: 0x00270A47
		public FKuroMaterialCurveColorGroup Group
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup result;
				if ((result = this._Group) == null)
				{
					result = (this._Group = new FKuroMaterialCurveColorGroup(base.NativePtr + (IntPtr)FKuroMaterialNamedColorGroup.__PropertyOffset_Group, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialNamedColorGroup.__PropertyOffset_Group, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A8E3 RID: 108771 RVA: 0x00272868 File Offset: 0x00270A68
		public FKuroMaterialNamedColorGroup()
		{
		}

		// Token: 0x0601A8E4 RID: 108772 RVA: 0x00272870 File Offset: 0x00270A70
		public FKuroMaterialNamedColorGroup(FName Name, FKuroMaterialCurveColorGroup Group)
		{
			this.Name = Name;
			this.Group = Group;
		}

		// Token: 0x0601A8E5 RID: 108773 RVA: 0x00272886 File Offset: 0x00270A86
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialNamedColorGroup.StaticStruct();
		}

		// Token: 0x0601A8E6 RID: 108774 RVA: 0x00272892 File Offset: 0x00270A92
		[NullableContext(2)]
		public FKuroMaterialNamedColorGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A8E7 RID: 108775 RVA: 0x0027289C File Offset: 0x00270A9C
		public FKuroMaterialNamedColorGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A8E8 RID: 108776 RVA: 0x002728A7 File Offset: 0x00270AA7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialNamedColorGroup(Pointer, false, true);
		}

		// Token: 0x0601A8E9 RID: 108777 RVA: 0x002728B1 File Offset: 0x00270AB1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialNamedColorGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400E614 RID: 58900
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedColorGroup";

		// Token: 0x0400E615 RID: 58901
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E616 RID: 58902
		internal static int __PropertyOffset_Name;

		// Token: 0x0400E617 RID: 58903
		internal static int __PropertyOffset_Group;

		// Token: 0x0400E618 RID: 58904
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup _Group;
	}
}
