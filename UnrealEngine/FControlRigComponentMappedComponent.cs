using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004BE RID: 1214
	[UnrealObjectPath("/Script/ControlRig.ControlRigComponentMappedComponent")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FControlRigComponentMappedComponent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004114 RID: 16660 RVA: 0x00061935 File Offset: 0x0005FB35
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigComponentMappedComponent._ScriptStructPtr != 0) ? FControlRigComponentMappedComponent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigComponentMappedComponent", ref FControlRigComponentMappedComponent._ScriptStructPtr);
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x00061959 File Offset: 0x0005FB59
		// (set) Token: 0x06004116 RID: 16662 RVA: 0x0006196D File Offset: 0x0005FB6D
		[Nullable(2)]
		public unsafe USceneComponent Component
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FControlRigComponentMappedComponent.__PropertyOffset_Component);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FControlRigComponentMappedComponent.__PropertyOffset_Component, value);
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x00061982 File Offset: 0x0005FB82
		// (set) Token: 0x06004118 RID: 16664 RVA: 0x00061996 File Offset: 0x0005FB96
		public unsafe FName ElementName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedComponent.__PropertyOffset_ElementName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedComponent.__PropertyOffset_ElementName) = value;
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06004119 RID: 16665 RVA: 0x000619AB File Offset: 0x0005FBAB
		// (set) Token: 0x0600411A RID: 16666 RVA: 0x000619BB File Offset: 0x0005FBBB
		public unsafe ERigElementType ElementType
		{
			get
			{
				return (ERigElementType)(*(base.NativePtr + (IntPtr)FControlRigComponentMappedComponent.__PropertyOffset_ElementType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedComponent.__PropertyOffset_ElementType) = (byte)value;
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x0600411B RID: 16667 RVA: 0x000619CC File Offset: 0x0005FBCC
		// (set) Token: 0x0600411C RID: 16668 RVA: 0x000619DC File Offset: 0x0005FBDC
		public unsafe EControlRigComponentMapDirection Direction
		{
			get
			{
				return (EControlRigComponentMapDirection)(*(base.NativePtr + (IntPtr)FControlRigComponentMappedComponent.__PropertyOffset_Direction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedComponent.__PropertyOffset_Direction) = (byte)value;
			}
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x000619ED File Offset: 0x0005FBED
		public FControlRigComponentMappedComponent()
		{
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x000619F5 File Offset: 0x0005FBF5
		[NullableContext(1)]
		public FControlRigComponentMappedComponent(USceneComponent Component, FName ElementName, ERigElementType ElementType, EControlRigComponentMapDirection Direction)
		{
			this.Component = Component;
			this.ElementName = ElementName;
			this.ElementType = ElementType;
			this.Direction = Direction;
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x00061A1A File Offset: 0x0005FC1A
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigComponentMappedComponent.StaticStruct();
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x00061A26 File Offset: 0x0005FC26
		[NullableContext(2)]
		public FControlRigComponentMappedComponent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x00061A30 File Offset: 0x0005FC30
		public FControlRigComponentMappedComponent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x00061A3B File Offset: 0x0005FC3B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigComponentMappedComponent(Pointer, false, true);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x00061A45 File Offset: 0x0005FC45
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigComponentMappedComponent(Pointer, MemoryOwner);
		}

		// Token: 0x04001EF9 RID: 7929
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.ControlRigComponentMappedComponent";

		// Token: 0x04001EFA RID: 7930
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EFB RID: 7931
		internal static int __PropertyOffset_Component;

		// Token: 0x04001EFC RID: 7932
		internal static int __PropertyOffset_ElementName;

		// Token: 0x04001EFD RID: 7933
		internal static int __PropertyOffset_ElementType;

		// Token: 0x04001EFE RID: 7934
		internal static int __PropertyOffset_Direction;
	}
}
