using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004BF RID: 1215
	[UnrealObjectPath("/Script/ControlRig.ControlRigComponentMappedCurve")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FControlRigComponentMappedCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004124 RID: 16676 RVA: 0x00061A4E File Offset: 0x0005FC4E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigComponentMappedCurve._ScriptStructPtr != 0) ? FControlRigComponentMappedCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigComponentMappedCurve", ref FControlRigComponentMappedCurve._ScriptStructPtr);
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x00061A72 File Offset: 0x0005FC72
		// (set) Token: 0x06004126 RID: 16678 RVA: 0x00061A86 File Offset: 0x0005FC86
		public unsafe FName Source
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedCurve.__PropertyOffset_Source);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedCurve.__PropertyOffset_Source) = value;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06004127 RID: 16679 RVA: 0x00061A9B File Offset: 0x0005FC9B
		// (set) Token: 0x06004128 RID: 16680 RVA: 0x00061AAF File Offset: 0x0005FCAF
		public unsafe FName Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigComponentMappedCurve.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigComponentMappedCurve.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x00061AC4 File Offset: 0x0005FCC4
		public FControlRigComponentMappedCurve()
		{
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x00061ACC File Offset: 0x0005FCCC
		public FControlRigComponentMappedCurve(FName Source, FName Target)
		{
			this.Source = Source;
			this.Target = Target;
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00061AE2 File Offset: 0x0005FCE2
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigComponentMappedCurve.StaticStruct();
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x00061AEE File Offset: 0x0005FCEE
		[NullableContext(2)]
		public FControlRigComponentMappedCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00061AF8 File Offset: 0x0005FCF8
		public FControlRigComponentMappedCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00061B03 File Offset: 0x0005FD03
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigComponentMappedCurve(Pointer, false, true);
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00061B0D File Offset: 0x0005FD0D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigComponentMappedCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04001EFF RID: 7935
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.ControlRigComponentMappedCurve";

		// Token: 0x04001F00 RID: 7936
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F01 RID: 7937
		internal static int __PropertyOffset_Source;

		// Token: 0x04001F02 RID: 7938
		internal static int __PropertyOffset_Target;
	}
}
