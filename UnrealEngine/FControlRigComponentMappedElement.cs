using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C0 RID: 1216
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigComponentMappedElement")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FControlRigComponentMappedElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004130 RID: 16688 RVA: 0x00061B16 File Offset: 0x0005FD16
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigComponentMappedElement._ScriptStructPtr != 0) ? FControlRigComponentMappedElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigComponentMappedElement", ref FControlRigComponentMappedElement._ScriptStructPtr);
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06004131 RID: 16689 RVA: 0x00061B3C File Offset: 0x0005FD3C
		// (set) Token: 0x06004132 RID: 16690 RVA: 0x00061B7F File Offset: 0x0005FD7F
		public FComponentReference ComponentReference
		{
			get
			{
				base.FastCheckIsValid();
				FComponentReference result;
				if ((result = this._ComponentReference) == null)
				{
					result = (this._ComponentReference = new FComponentReference(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_ComponentReference, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComponentReference.StaticStruct(), base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_ComponentReference, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06004133 RID: 16691 RVA: 0x00061BA0 File Offset: 0x0005FDA0
		// (set) Token: 0x06004134 RID: 16692 RVA: 0x00061BB0 File Offset: 0x0005FDB0
		public unsafe int TransformIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_TransformIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_TransformIndex) = value;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x00061BC1 File Offset: 0x0005FDC1
		// (set) Token: 0x06004136 RID: 16694 RVA: 0x00061BD5 File Offset: 0x0005FDD5
		public unsafe FName TransformName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_TransformName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_TransformName) = value;
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06004137 RID: 16695 RVA: 0x00061BEA File Offset: 0x0005FDEA
		// (set) Token: 0x06004138 RID: 16696 RVA: 0x00061BFA File Offset: 0x0005FDFA
		public unsafe ERigElementType ElementType
		{
			get
			{
				return (ERigElementType)(*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_ElementType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_ElementType) = (byte)value;
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x00061C0B File Offset: 0x0005FE0B
		// (set) Token: 0x0600413A RID: 16698 RVA: 0x00061C1F File Offset: 0x0005FE1F
		public unsafe FName ElementName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_ElementName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_ElementName) = value;
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x00061C34 File Offset: 0x0005FE34
		// (set) Token: 0x0600413C RID: 16700 RVA: 0x00061C44 File Offset: 0x0005FE44
		public unsafe EControlRigComponentMapDirection Direction
		{
			get
			{
				return (EControlRigComponentMapDirection)(*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_Direction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_Direction) = (byte)value;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x00061C55 File Offset: 0x0005FE55
		// (set) Token: 0x0600413E RID: 16702 RVA: 0x00061C69 File Offset: 0x0005FE69
		public unsafe FTransform Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x0600413F RID: 16703 RVA: 0x00061C7E File Offset: 0x0005FE7E
		// (set) Token: 0x06004140 RID: 16704 RVA: 0x00061C8E File Offset: 0x0005FE8E
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x00061C9F File Offset: 0x0005FE9F
		// (set) Token: 0x06004142 RID: 16706 RVA: 0x00061CAF File Offset: 0x0005FEAF
		public unsafe EControlRigComponentSpace Space
		{
			get
			{
				return (EControlRigComponentSpace)(*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x00061CC0 File Offset: 0x0005FEC0
		// (set) Token: 0x06004144 RID: 16708 RVA: 0x00061CD4 File Offset: 0x0005FED4
		[Nullable(2)]
		public unsafe USceneComponent SceneComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FControlRigComponentMappedElement.__PropertyOffset_SceneComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FControlRigComponentMappedElement.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x00061CE9 File Offset: 0x0005FEE9
		// (set) Token: 0x06004146 RID: 16710 RVA: 0x00061CF9 File Offset: 0x0005FEF9
		public unsafe int ElementIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_ElementIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_ElementIndex) = value;
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x00061D0A File Offset: 0x0005FF0A
		// (set) Token: 0x06004148 RID: 16712 RVA: 0x00061D1A File Offset: 0x0005FF1A
		public unsafe int SubIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_SubIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedElement.__PropertyOffset_SubIndex) = value;
			}
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x00061D2B File Offset: 0x0005FF2B
		public FControlRigComponentMappedElement()
		{
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x00061D34 File Offset: 0x0005FF34
		public FControlRigComponentMappedElement(FComponentReference ComponentReference, int TransformIndex, FName TransformName, ERigElementType ElementType, FName ElementName, EControlRigComponentMapDirection Direction, FTransform Offset, float Weight, EControlRigComponentSpace Space, USceneComponent SceneComponent, int ElementIndex, int SubIndex)
		{
			this.ComponentReference = ComponentReference;
			this.TransformIndex = TransformIndex;
			this.TransformName = TransformName;
			this.ElementType = ElementType;
			this.ElementName = ElementName;
			this.Direction = Direction;
			this.Offset = Offset;
			this.Weight = Weight;
			this.Space = Space;
			this.SceneComponent = SceneComponent;
			this.ElementIndex = ElementIndex;
			this.SubIndex = SubIndex;
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00061DA4 File Offset: 0x0005FFA4
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigComponentMappedElement.StaticStruct();
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00061DB0 File Offset: 0x0005FFB0
		[NullableContext(2)]
		public FControlRigComponentMappedElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x00061DBA File Offset: 0x0005FFBA
		public FControlRigComponentMappedElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x00061DC5 File Offset: 0x0005FFC5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigComponentMappedElement(Pointer, false, true);
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x00061DCF File Offset: 0x0005FFCF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigComponentMappedElement(Pointer, MemoryOwner);
		}

		// Token: 0x04001F03 RID: 7939
		public const string __ObjectPath = "/Script/ControlRig.ControlRigComponentMappedElement";

		// Token: 0x04001F04 RID: 7940
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F05 RID: 7941
		internal static int __PropertyOffset_ComponentReference;

		// Token: 0x04001F06 RID: 7942
		[Nullable(2)]
		private FComponentReference _ComponentReference;

		// Token: 0x04001F07 RID: 7943
		internal static int __PropertyOffset_TransformIndex;

		// Token: 0x04001F08 RID: 7944
		internal static int __PropertyOffset_TransformName;

		// Token: 0x04001F09 RID: 7945
		internal static int __PropertyOffset_ElementType;

		// Token: 0x04001F0A RID: 7946
		internal static int __PropertyOffset_ElementName;

		// Token: 0x04001F0B RID: 7947
		internal static int __PropertyOffset_Direction;

		// Token: 0x04001F0C RID: 7948
		internal static int __PropertyOffset_Offset;

		// Token: 0x04001F0D RID: 7949
		internal static int __PropertyOffset_Weight;

		// Token: 0x04001F0E RID: 7950
		internal static int __PropertyOffset_Space;

		// Token: 0x04001F0F RID: 7951
		internal static int __PropertyOffset_SceneComponent;

		// Token: 0x04001F10 RID: 7952
		internal static int __PropertyOffset_ElementIndex;

		// Token: 0x04001F11 RID: 7953
		internal static int __PropertyOffset_SubIndex;
	}
}
