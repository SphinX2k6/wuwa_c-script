using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019AA RID: 6570
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.SPModelSCPMap")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FSPModelSCPMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018731 RID: 100145 RVA: 0x00240831 File Offset: 0x0023EA31
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSPModelSCPMap._ScriptStructPtr != 0) ? FSPModelSCPMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.SPModelSCPMap", ref FSPModelSCPMap._ScriptStructPtr);
		}

		// Token: 0x170061A7 RID: 24999
		// (get) Token: 0x06018732 RID: 100146 RVA: 0x00240858 File Offset: 0x0023EA58
		// (set) Token: 0x06018733 RID: 100147 RVA: 0x0024089B File Offset: 0x0023EA9B
		public TMap<int, FSPModelShiftColorParameter> ModelColorMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FSPModelShiftColorParameter> result;
				if ((result = this._ModelColorMap) == null)
				{
					result = (this._ModelColorMap = new TMap<int, FSPModelShiftColorParameter>(base.NativePtr + (IntPtr)FSPModelSCPMap.__PropertyOffset_ModelColorMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModelColorMap.CopyAssign(value);
			}
		}

		// Token: 0x06018734 RID: 100148 RVA: 0x002408A9 File Offset: 0x0023EAA9
		public FSPModelSCPMap()
		{
		}

		// Token: 0x06018735 RID: 100149 RVA: 0x002408B1 File Offset: 0x0023EAB1
		public FSPModelSCPMap(TMap<int, FSPModelShiftColorParameter> ModelColorMap)
		{
			this.ModelColorMap = ModelColorMap;
		}

		// Token: 0x06018736 RID: 100150 RVA: 0x002408C0 File Offset: 0x0023EAC0
		protected override IntPtr GetUStructPtr()
		{
			return FSPModelSCPMap.StaticStruct();
		}

		// Token: 0x06018737 RID: 100151 RVA: 0x002408CC File Offset: 0x0023EACC
		[NullableContext(2)]
		public FSPModelSCPMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018738 RID: 100152 RVA: 0x002408D6 File Offset: 0x0023EAD6
		public FSPModelSCPMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018739 RID: 100153 RVA: 0x002408E1 File Offset: 0x0023EAE1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSPModelSCPMap(Pointer, false, true);
		}

		// Token: 0x0601873A RID: 100154 RVA: 0x002408EB File Offset: 0x0023EAEB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSPModelSCPMap(Pointer, MemoryOwner);
		}

		// Token: 0x0400D358 RID: 54104
		public const string __ObjectPath = "/Script/KuroInteractionEffect.SPModelSCPMap";

		// Token: 0x0400D359 RID: 54105
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D35A RID: 54106
		internal static int __PropertyOffset_ModelColorMap;

		// Token: 0x0400D35B RID: 54107
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FSPModelShiftColorParameter> _ModelColorMap;
	}
}
