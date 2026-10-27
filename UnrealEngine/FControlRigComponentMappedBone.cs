using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004BD RID: 1213
	[UnrealObjectPath("/Script/ControlRig.ControlRigComponentMappedBone")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FControlRigComponentMappedBone : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004108 RID: 16648 RVA: 0x0006186D File Offset: 0x0005FA6D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigComponentMappedBone._ScriptStructPtr != 0) ? FControlRigComponentMappedBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigComponentMappedBone", ref FControlRigComponentMappedBone._ScriptStructPtr);
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06004109 RID: 16649 RVA: 0x00061891 File Offset: 0x0005FA91
		// (set) Token: 0x0600410A RID: 16650 RVA: 0x000618A5 File Offset: 0x0005FAA5
		public unsafe FName Source
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedBone.__PropertyOffset_Source);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedBone.__PropertyOffset_Source) = value;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x0600410B RID: 16651 RVA: 0x000618BA File Offset: 0x0005FABA
		// (set) Token: 0x0600410C RID: 16652 RVA: 0x000618CE File Offset: 0x0005FACE
		public unsafe FName Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedBone.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedBone.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x000618E3 File Offset: 0x0005FAE3
		public FControlRigComponentMappedBone()
		{
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x000618EB File Offset: 0x0005FAEB
		public FControlRigComponentMappedBone(FName Source, FName Target)
		{
			this.Source = Source;
			this.Target = Target;
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x00061901 File Offset: 0x0005FB01
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigComponentMappedBone.StaticStruct();
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x0006190D File Offset: 0x0005FB0D
		[NullableContext(2)]
		public FControlRigComponentMappedBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00061917 File Offset: 0x0005FB17
		public FControlRigComponentMappedBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x00061922 File Offset: 0x0005FB22
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigComponentMappedBone(Pointer, false, true);
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x0006192C File Offset: 0x0005FB2C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigComponentMappedBone(Pointer, MemoryOwner);
		}

		// Token: 0x04001EF5 RID: 7925
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.ControlRigComponentMappedBone";

		// Token: 0x04001EF6 RID: 7926
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EF7 RID: 7927
		internal static int __PropertyOffset_Source;

		// Token: 0x04001EF8 RID: 7928
		internal static int __PropertyOffset_Target;
	}
}
