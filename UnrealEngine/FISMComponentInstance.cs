using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CC2 RID: 3266
	[UnrealObjectPath("/Script/Engine.ISMComponentInstance")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FISMComponentInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A50F RID: 42255 RVA: 0x000EAC74 File Offset: 0x000E8E74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FISMComponentInstance._ScriptStructPtr != 0) ? FISMComponentInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ISMComponentInstance", ref FISMComponentInstance._ScriptStructPtr);
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x0600A510 RID: 42256 RVA: 0x000EAC98 File Offset: 0x000E8E98
		// (set) Token: 0x0600A511 RID: 42257 RVA: 0x000EACA8 File Offset: 0x000E8EA8
		public unsafe int ClientIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FISMComponentInstance.__PropertyOffset_ClientIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FISMComponentInstance.__PropertyOffset_ClientIndex) = value;
			}
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x0600A512 RID: 42258 RVA: 0x000EACB9 File Offset: 0x000E8EB9
		// (set) Token: 0x0600A513 RID: 42259 RVA: 0x000EACC9 File Offset: 0x000E8EC9
		public unsafe int InstanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FISMComponentInstance.__PropertyOffset_InstanceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FISMComponentInstance.__PropertyOffset_InstanceIndex) = value;
			}
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x0600A514 RID: 42260 RVA: 0x000EACDA File Offset: 0x000E8EDA
		// (set) Token: 0x0600A515 RID: 42261 RVA: 0x000EACEA File Offset: 0x000E8EEA
		public unsafe int InstanceSubIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FISMComponentInstance.__PropertyOffset_InstanceSubIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FISMComponentInstance.__PropertyOffset_InstanceSubIndex) = value;
			}
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x000EACFB File Offset: 0x000E8EFB
		public FISMComponentInstance()
		{
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x000EAD03 File Offset: 0x000E8F03
		public FISMComponentInstance(int ClientIndex, int InstanceIndex, int InstanceSubIndex)
		{
			this.ClientIndex = ClientIndex;
			this.InstanceIndex = InstanceIndex;
			this.InstanceSubIndex = InstanceSubIndex;
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x000EAD20 File Offset: 0x000E8F20
		protected override IntPtr GetUStructPtr()
		{
			return FISMComponentInstance.StaticStruct();
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x000EAD2C File Offset: 0x000E8F2C
		[NullableContext(2)]
		public FISMComponentInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x000EAD36 File Offset: 0x000E8F36
		public FISMComponentInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x000EAD41 File Offset: 0x000E8F41
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FISMComponentInstance(Pointer, false, true);
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x000EAD4B File Offset: 0x000E8F4B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FISMComponentInstance(Pointer, MemoryOwner);
		}

		// Token: 0x04005ACD RID: 23245
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ISMComponentInstance";

		// Token: 0x04005ACE RID: 23246
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005ACF RID: 23247
		internal static int __PropertyOffset_ClientIndex;

		// Token: 0x04005AD0 RID: 23248
		internal static int __PropertyOffset_InstanceIndex;

		// Token: 0x04005AD1 RID: 23249
		internal static int __PropertyOffset_InstanceSubIndex;
	}
}
