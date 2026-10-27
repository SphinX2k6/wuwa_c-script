using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CBF RID: 3263
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ISMClientInstance")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FISMClientInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A4F5 RID: 42229 RVA: 0x000EAAE4 File Offset: 0x000E8CE4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FISMClientInstance._ScriptStructPtr != 0) ? FISMClientInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ISMClientInstance", ref FISMClientInstance._ScriptStructPtr);
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x0600A4F6 RID: 42230 RVA: 0x000EAB08 File Offset: 0x000E8D08
		// (set) Token: 0x0600A4F7 RID: 42231 RVA: 0x000EAB4B File Offset: 0x000E8D4B
		public TArray<int> ComponentIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ComponentIndices) == null)
				{
					result = (this._ComponentIndices = new TArray<int>(base.NativePtr + (IntPtr)FISMClientInstance.__PropertyOffset_ComponentIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentIndices.CopyAssign(value);
			}
		}

		// Token: 0x0600A4F8 RID: 42232 RVA: 0x000EAB59 File Offset: 0x000E8D59
		public FISMClientInstance()
		{
		}

		// Token: 0x0600A4F9 RID: 42233 RVA: 0x000EAB61 File Offset: 0x000E8D61
		public FISMClientInstance(TArray<int> ComponentIndices)
		{
			this.ComponentIndices = ComponentIndices;
		}

		// Token: 0x0600A4FA RID: 42234 RVA: 0x000EAB70 File Offset: 0x000E8D70
		protected override IntPtr GetUStructPtr()
		{
			return FISMClientInstance.StaticStruct();
		}

		// Token: 0x0600A4FB RID: 42235 RVA: 0x000EAB7C File Offset: 0x000E8D7C
		[NullableContext(2)]
		public FISMClientInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x000EAB86 File Offset: 0x000E8D86
		public FISMClientInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x000EAB91 File Offset: 0x000E8D91
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FISMClientInstance(Pointer, false, true);
		}

		// Token: 0x0600A4FE RID: 42238 RVA: 0x000EAB9B File Offset: 0x000E8D9B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FISMClientInstance(Pointer, MemoryOwner);
		}

		// Token: 0x04005AC5 RID: 23237
		public const string __ObjectPath = "/Script/Engine.ISMClientInstance";

		// Token: 0x04005AC6 RID: 23238
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005AC7 RID: 23239
		internal static int __PropertyOffset_ComponentIndices;

		// Token: 0x04005AC8 RID: 23240
		[Nullable(2)]
		private TArray<int> _ComponentIndices;
	}
}
