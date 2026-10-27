using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002618 RID: 9752
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OnlineSubsystem.NamedInterfaceDef")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNamedInterfaceDef : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602445A RID: 148570 RVA: 0x0035B348 File Offset: 0x00359548
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedInterfaceDef._ScriptStructPtr != 0) ? FNamedInterfaceDef._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/OnlineSubsystem.NamedInterfaceDef", ref FNamedInterfaceDef._ScriptStructPtr);
		}

		// Token: 0x17008BAD RID: 35757
		// (get) Token: 0x0602445B RID: 148571 RVA: 0x0035B36C File Offset: 0x0035956C
		// (set) Token: 0x0602445C RID: 148572 RVA: 0x0035B380 File Offset: 0x00359580
		public unsafe FName InterfaceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedInterfaceDef.__PropertyOffset_InterfaceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedInterfaceDef.__PropertyOffset_InterfaceName) = value;
			}
		}

		// Token: 0x17008BAE RID: 35758
		// (get) Token: 0x0602445D RID: 148573 RVA: 0x0035B395 File Offset: 0x00359595
		// (set) Token: 0x0602445E RID: 148574 RVA: 0x0035B3A9 File Offset: 0x003595A9
		public unsafe string InterfaceClassName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNamedInterfaceDef.__PropertyOffset_InterfaceClassName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNamedInterfaceDef.__PropertyOffset_InterfaceClassName)), value);
			}
		}

		// Token: 0x0602445F RID: 148575 RVA: 0x0035B3BE File Offset: 0x003595BE
		public FNamedInterfaceDef()
		{
		}

		// Token: 0x06024460 RID: 148576 RVA: 0x0035B3C6 File Offset: 0x003595C6
		public FNamedInterfaceDef(FName InterfaceName, string InterfaceClassName)
		{
			this.InterfaceName = InterfaceName;
			this.InterfaceClassName = InterfaceClassName;
		}

		// Token: 0x06024461 RID: 148577 RVA: 0x0035B3DC File Offset: 0x003595DC
		protected override IntPtr GetUStructPtr()
		{
			return FNamedInterfaceDef.StaticStruct();
		}

		// Token: 0x06024462 RID: 148578 RVA: 0x0035B3E8 File Offset: 0x003595E8
		[NullableContext(2)]
		public FNamedInterfaceDef(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024463 RID: 148579 RVA: 0x0035B3F2 File Offset: 0x003595F2
		public FNamedInterfaceDef(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024464 RID: 148580 RVA: 0x0035B3FD File Offset: 0x003595FD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedInterfaceDef(Pointer, false, true);
		}

		// Token: 0x06024465 RID: 148581 RVA: 0x0035B407 File Offset: 0x00359607
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedInterfaceDef(Pointer, MemoryOwner);
		}

		// Token: 0x0401374F RID: 79695
		public const string __ObjectPath = "/Script/OnlineSubsystem.NamedInterfaceDef";

		// Token: 0x04013750 RID: 79696
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013751 RID: 79697
		internal static int __PropertyOffset_InterfaceName;

		// Token: 0x04013752 RID: 79698
		internal static int __PropertyOffset_InterfaceClassName;
	}
}
