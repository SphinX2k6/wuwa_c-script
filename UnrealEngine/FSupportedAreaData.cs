using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024B1 RID: 9393
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.SupportedAreaData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSupportedAreaData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060232D6 RID: 144086 RVA: 0x00340986 File Offset: 0x0033EB86
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSupportedAreaData._ScriptStructPtr != 0) ? FSupportedAreaData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.SupportedAreaData", ref FSupportedAreaData._ScriptStructPtr);
		}

		// Token: 0x1700874A RID: 34634
		// (get) Token: 0x060232D7 RID: 144087 RVA: 0x003409AA File Offset: 0x0033EBAA
		// (set) Token: 0x060232D8 RID: 144088 RVA: 0x003409BE File Offset: 0x0033EBBE
		public unsafe string AreaClassName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSupportedAreaData.__PropertyOffset_AreaClassName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSupportedAreaData.__PropertyOffset_AreaClassName)), value);
			}
		}

		// Token: 0x1700874B RID: 34635
		// (get) Token: 0x060232D9 RID: 144089 RVA: 0x003409D3 File Offset: 0x0033EBD3
		// (set) Token: 0x060232DA RID: 144090 RVA: 0x003409E3 File Offset: 0x0033EBE3
		public unsafe int AreaID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSupportedAreaData.__PropertyOffset_AreaID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSupportedAreaData.__PropertyOffset_AreaID) = value;
			}
		}

		// Token: 0x1700874C RID: 34636
		// (get) Token: 0x060232DB RID: 144091 RVA: 0x003409F4 File Offset: 0x0033EBF4
		// (set) Token: 0x060232DC RID: 144092 RVA: 0x00340A08 File Offset: 0x0033EC08
		public unsafe UClassStackOnlyPtr AreaClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSupportedAreaData.__PropertyOffset_AreaClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSupportedAreaData.__PropertyOffset_AreaClass) = value;
			}
		}

		// Token: 0x060232DD RID: 144093 RVA: 0x00340A1D File Offset: 0x0033EC1D
		public FSupportedAreaData()
		{
		}

		// Token: 0x060232DE RID: 144094 RVA: 0x00340A25 File Offset: 0x0033EC25
		public FSupportedAreaData(string AreaClassName, int AreaID, UClassStackOnlyPtr AreaClass)
		{
			this.AreaClassName = AreaClassName;
			this.AreaID = AreaID;
			this.AreaClass = AreaClass;
		}

		// Token: 0x060232DF RID: 144095 RVA: 0x00340A42 File Offset: 0x0033EC42
		protected override IntPtr GetUStructPtr()
		{
			return FSupportedAreaData.StaticStruct();
		}

		// Token: 0x060232E0 RID: 144096 RVA: 0x00340A4E File Offset: 0x0033EC4E
		[NullableContext(2)]
		public FSupportedAreaData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060232E1 RID: 144097 RVA: 0x00340A58 File Offset: 0x0033EC58
		public FSupportedAreaData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060232E2 RID: 144098 RVA: 0x00340A63 File Offset: 0x0033EC63
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSupportedAreaData(Pointer, false, true);
		}

		// Token: 0x060232E3 RID: 144099 RVA: 0x00340A6D File Offset: 0x0033EC6D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSupportedAreaData(Pointer, MemoryOwner);
		}

		// Token: 0x04012C9D RID: 76957
		public const string __ObjectPath = "/Script/NavigationSystem.SupportedAreaData";

		// Token: 0x04012C9E RID: 76958
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012C9F RID: 76959
		internal static int __PropertyOffset_AreaClassName;

		// Token: 0x04012CA0 RID: 76960
		internal static int __PropertyOffset_AreaID;

		// Token: 0x04012CA1 RID: 76961
		internal static int __PropertyOffset_AreaClass;
	}
}
