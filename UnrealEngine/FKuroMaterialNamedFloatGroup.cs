using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B6A RID: 7018
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedFloatGroup")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 448)]
	public class FKuroMaterialNamedFloatGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A902 RID: 108802 RVA: 0x00272A42 File Offset: 0x00270C42
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialNamedFloatGroup._ScriptStructPtr != 0) ? FKuroMaterialNamedFloatGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedFloatGroup", ref FKuroMaterialNamedFloatGroup._ScriptStructPtr);
		}

		// Token: 0x17006ABD RID: 27325
		// (get) Token: 0x0601A903 RID: 108803 RVA: 0x00272A66 File Offset: 0x00270C66
		// (set) Token: 0x0601A904 RID: 108804 RVA: 0x00272A7A File Offset: 0x00270C7A
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedFloatGroup.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedFloatGroup.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006ABE RID: 27326
		// (get) Token: 0x0601A905 RID: 108805 RVA: 0x00272A90 File Offset: 0x00270C90
		// (set) Token: 0x0601A906 RID: 108806 RVA: 0x00272AD3 File Offset: 0x00270CD3
		public FKuroMaterialCurveFloatGroup Group
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._Group) == null)
				{
					result = (this._Group = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialNamedFloatGroup.__PropertyOffset_Group, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialNamedFloatGroup.__PropertyOffset_Group, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A907 RID: 108807 RVA: 0x00272AF4 File Offset: 0x00270CF4
		public FKuroMaterialNamedFloatGroup()
		{
		}

		// Token: 0x0601A908 RID: 108808 RVA: 0x00272AFC File Offset: 0x00270CFC
		public FKuroMaterialNamedFloatGroup(FName Name, FKuroMaterialCurveFloatGroup Group)
		{
			this.Name = Name;
			this.Group = Group;
		}

		// Token: 0x0601A909 RID: 108809 RVA: 0x00272B12 File Offset: 0x00270D12
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialNamedFloatGroup.StaticStruct();
		}

		// Token: 0x0601A90A RID: 108810 RVA: 0x00272B1E File Offset: 0x00270D1E
		[NullableContext(2)]
		public FKuroMaterialNamedFloatGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A90B RID: 108811 RVA: 0x00272B28 File Offset: 0x00270D28
		public FKuroMaterialNamedFloatGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A90C RID: 108812 RVA: 0x00272B33 File Offset: 0x00270D33
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialNamedFloatGroup(Pointer, false, true);
		}

		// Token: 0x0601A90D RID: 108813 RVA: 0x00272B3D File Offset: 0x00270D3D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialNamedFloatGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400E621 RID: 58913
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedFloatGroup";

		// Token: 0x0400E622 RID: 58914
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E623 RID: 58915
		internal static int __PropertyOffset_Name;

		// Token: 0x0400E624 RID: 58916
		internal static int __PropertyOffset_Group;

		// Token: 0x0400E625 RID: 58917
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _Group;
	}
}
