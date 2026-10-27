using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EEF RID: 3823
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Node")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CF5C RID: 53084 RVA: 0x0012E82C File Offset: 0x0012CA2C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNode._ScriptStructPtr != 0) ? FNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Node", ref FNode._ScriptStructPtr);
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x0600CF5D RID: 53085 RVA: 0x0012E850 File Offset: 0x0012CA50
		// (set) Token: 0x0600CF5E RID: 53086 RVA: 0x0012E864 File Offset: 0x0012CA64
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNode.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNode.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x0600CF5F RID: 53087 RVA: 0x0012E879 File Offset: 0x0012CA79
		// (set) Token: 0x0600CF60 RID: 53088 RVA: 0x0012E88D File Offset: 0x0012CA8D
		public unsafe FName ParentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNode.__PropertyOffset_ParentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNode.__PropertyOffset_ParentName) = value;
			}
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x0600CF61 RID: 53089 RVA: 0x0012E8A2 File Offset: 0x0012CAA2
		// (set) Token: 0x0600CF62 RID: 53090 RVA: 0x0012E8B6 File Offset: 0x0012CAB6
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNode.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNode.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x0600CF63 RID: 53091 RVA: 0x0012E8CB File Offset: 0x0012CACB
		// (set) Token: 0x0600CF64 RID: 53092 RVA: 0x0012E8DF File Offset: 0x0012CADF
		public unsafe string DisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNode.__PropertyOffset_DisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNode.__PropertyOffset_DisplayName)), value);
			}
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x0600CF65 RID: 53093 RVA: 0x0012E8F4 File Offset: 0x0012CAF4
		// (set) Token: 0x0600CF66 RID: 53094 RVA: 0x0012E904 File Offset: 0x0012CB04
		public unsafe bool bAdvanced
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNode.__PropertyOffset_bAdvanced) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNode.__PropertyOffset_bAdvanced) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600CF67 RID: 53095 RVA: 0x0012E915 File Offset: 0x0012CB15
		public FNode()
		{
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x0012E91D File Offset: 0x0012CB1D
		public FNode(FName Name, FName ParentName, FTransform Transform, string DisplayName, bool bAdvanced)
		{
			this.Name = Name;
			this.ParentName = ParentName;
			this.Transform = Transform;
			this.DisplayName = DisplayName;
			this.bAdvanced = bAdvanced;
		}

		// Token: 0x0600CF69 RID: 53097 RVA: 0x0012E94A File Offset: 0x0012CB4A
		protected override IntPtr GetUStructPtr()
		{
			return FNode.StaticStruct();
		}

		// Token: 0x0600CF6A RID: 53098 RVA: 0x0012E956 File Offset: 0x0012CB56
		[NullableContext(2)]
		public FNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CF6B RID: 53099 RVA: 0x0012E960 File Offset: 0x0012CB60
		public FNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CF6C RID: 53100 RVA: 0x0012E96B File Offset: 0x0012CB6B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNode(Pointer, false, true);
		}

		// Token: 0x0600CF6D RID: 53101 RVA: 0x0012E975 File Offset: 0x0012CB75
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNode(Pointer, MemoryOwner);
		}

		// Token: 0x04006FD2 RID: 28626
		public const string __ObjectPath = "/Script/Engine.Node";

		// Token: 0x04006FD3 RID: 28627
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006FD4 RID: 28628
		internal static int __PropertyOffset_Name;

		// Token: 0x04006FD5 RID: 28629
		internal static int __PropertyOffset_ParentName;

		// Token: 0x04006FD6 RID: 28630
		internal static int __PropertyOffset_Transform;

		// Token: 0x04006FD7 RID: 28631
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04006FD8 RID: 28632
		internal static int __PropertyOffset_bAdvanced;
	}
}
