using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C5 RID: 709
	[UnrealObjectPath("/Script/AnimationCore.NodeObject")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNodeObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600274F RID: 10063 RVA: 0x0003AF8B File Offset: 0x0003918B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNodeObject._ScriptStructPtr != 0) ? FNodeObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.NodeObject", ref FNodeObject._ScriptStructPtr);
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x0003AFAF File Offset: 0x000391AF
		// (set) Token: 0x06002751 RID: 10065 RVA: 0x0003AFC3 File Offset: 0x000391C3
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNodeObject.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNodeObject.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x0003AFD8 File Offset: 0x000391D8
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x0003AFEC File Offset: 0x000391EC
		public unsafe FName ParentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNodeObject.__PropertyOffset_ParentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNodeObject.__PropertyOffset_ParentName) = value;
			}
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0003B001 File Offset: 0x00039201
		public FNodeObject()
		{
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0003B009 File Offset: 0x00039209
		public FNodeObject(FName Name, FName ParentName)
		{
			this.Name = Name;
			this.ParentName = ParentName;
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x0003B01F File Offset: 0x0003921F
		protected override IntPtr GetUStructPtr()
		{
			return FNodeObject.StaticStruct();
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x0003B02B File Offset: 0x0003922B
		[NullableContext(2)]
		public FNodeObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x0003B035 File Offset: 0x00039235
		public FNodeObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x0003B040 File Offset: 0x00039240
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNodeObject(Pointer, false, true);
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0003B04A File Offset: 0x0003924A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNodeObject(Pointer, MemoryOwner);
		}

		// Token: 0x04000F7F RID: 3967
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimationCore.NodeObject";

		// Token: 0x04000F80 RID: 3968
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F81 RID: 3969
		internal static int __PropertyOffset_Name;

		// Token: 0x04000F82 RID: 3970
		internal static int __PropertyOffset_ParentName;
	}
}
