using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C3B RID: 3131
	[UnrealObjectPath("/Script/Engine.HLODProxyMesh")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FHLODProxyMesh : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009EA8 RID: 40616 RVA: 0x000E181A File Offset: 0x000DFA1A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODProxyMesh._ScriptStructPtr != 0) ? FHLODProxyMesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODProxyMesh", ref FHLODProxyMesh._ScriptStructPtr);
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x06009EA9 RID: 40617 RVA: 0x000E183E File Offset: 0x000DFA3E
		// (set) Token: 0x06009EAA RID: 40618 RVA: 0x000E1852 File Offset: 0x000DFA52
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<ALODActor> LODActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FHLODProxyMesh.__PropertyOffset_LODActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FHLODProxyMesh.__PropertyOffset_LODActor) = value;
			}
		}

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x06009EAB RID: 40619 RVA: 0x000E1867 File Offset: 0x000DFA67
		// (set) Token: 0x06009EAC RID: 40620 RVA: 0x000E187B File Offset: 0x000DFA7B
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FHLODProxyMesh.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHLODProxyMesh.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x06009EAD RID: 40621 RVA: 0x000E1890 File Offset: 0x000DFA90
		// (set) Token: 0x06009EAE RID: 40622 RVA: 0x000E18A4 File Offset: 0x000DFAA4
		public unsafe FName Key
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHLODProxyMesh.__PropertyOffset_Key);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHLODProxyMesh.__PropertyOffset_Key) = value;
			}
		}

		// Token: 0x06009EAF RID: 40623 RVA: 0x000E18B9 File Offset: 0x000DFAB9
		public FHLODProxyMesh()
		{
		}

		// Token: 0x06009EB0 RID: 40624 RVA: 0x000E18C1 File Offset: 0x000DFAC1
		[NullableContext(1)]
		public FHLODProxyMesh([Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<ALODActor> LODActor, UStaticMesh StaticMesh, FName Key)
		{
			this.LODActor = LODActor;
			this.StaticMesh = StaticMesh;
			this.Key = Key;
		}

		// Token: 0x06009EB1 RID: 40625 RVA: 0x000E18DE File Offset: 0x000DFADE
		protected override IntPtr GetUStructPtr()
		{
			return FHLODProxyMesh.StaticStruct();
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x000E18EA File Offset: 0x000DFAEA
		[NullableContext(2)]
		public FHLODProxyMesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009EB3 RID: 40627 RVA: 0x000E18F4 File Offset: 0x000DFAF4
		public FHLODProxyMesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009EB4 RID: 40628 RVA: 0x000E18FF File Offset: 0x000DFAFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODProxyMesh(Pointer, false, true);
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x000E1909 File Offset: 0x000DFB09
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODProxyMesh(Pointer, MemoryOwner);
		}

		// Token: 0x04005776 RID: 22390
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.HLODProxyMesh";

		// Token: 0x04005777 RID: 22391
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005778 RID: 22392
		internal static int __PropertyOffset_LODActor;

		// Token: 0x04005779 RID: 22393
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400577A RID: 22394
		internal static int __PropertyOffset_Key;
	}
}
