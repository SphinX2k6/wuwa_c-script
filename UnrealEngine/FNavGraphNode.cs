using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002489 RID: 9353
	[UnrealObjectPath("/Script/NavigationSystem.NavGraphNode")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNavGraphNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022FA3 RID: 143267 RVA: 0x0033B615 File Offset: 0x00339815
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavGraphNode._ScriptStructPtr != 0) ? FNavGraphNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.NavGraphNode", ref FNavGraphNode._ScriptStructPtr);
		}

		// Token: 0x17008658 RID: 34392
		// (get) Token: 0x06022FA4 RID: 143268 RVA: 0x0033B639 File Offset: 0x00339839
		// (set) Token: 0x06022FA5 RID: 143269 RVA: 0x0033B64D File Offset: 0x0033984D
		[Nullable(2)]
		public unsafe UObject Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FNavGraphNode.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNavGraphNode.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x06022FA6 RID: 143270 RVA: 0x0033B662 File Offset: 0x00339862
		public FNavGraphNode()
		{
		}

		// Token: 0x06022FA7 RID: 143271 RVA: 0x0033B66A File Offset: 0x0033986A
		[NullableContext(1)]
		public FNavGraphNode(UObject Owner)
		{
			this.Owner = Owner;
		}

		// Token: 0x06022FA8 RID: 143272 RVA: 0x0033B679 File Offset: 0x00339879
		protected override IntPtr GetUStructPtr()
		{
			return FNavGraphNode.StaticStruct();
		}

		// Token: 0x06022FA9 RID: 143273 RVA: 0x0033B685 File Offset: 0x00339885
		[NullableContext(2)]
		public FNavGraphNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022FAA RID: 143274 RVA: 0x0033B68F File Offset: 0x0033988F
		public FNavGraphNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022FAB RID: 143275 RVA: 0x0033B69A File Offset: 0x0033989A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavGraphNode(Pointer, false, true);
		}

		// Token: 0x06022FAC RID: 143276 RVA: 0x0033B6A4 File Offset: 0x003398A4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavGraphNode(Pointer, MemoryOwner);
		}

		// Token: 0x04012AD6 RID: 76502
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.NavGraphNode";

		// Token: 0x04012AD7 RID: 76503
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012AD8 RID: 76504
		internal static int __PropertyOffset_Owner;
	}
}
