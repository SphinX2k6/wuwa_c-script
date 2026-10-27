using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A72 RID: 10866
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseFileHandler.WwiseExternalSourceCookedData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FWwiseExternalSourceCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028113 RID: 164115 RVA: 0x003CFE33 File Offset: 0x003CE033
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseExternalSourceCookedData._ScriptStructPtr != 0) ? FWwiseExternalSourceCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseFileHandler.WwiseExternalSourceCookedData", ref FWwiseExternalSourceCookedData._ScriptStructPtr);
		}

		// Token: 0x170098FE RID: 39166
		// (get) Token: 0x06028114 RID: 164116 RVA: 0x003CFE57 File Offset: 0x003CE057
		// (set) Token: 0x06028115 RID: 164117 RVA: 0x003CFE67 File Offset: 0x003CE067
		public unsafe int Cookie
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceCookedData.__PropertyOffset_Cookie);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceCookedData.__PropertyOffset_Cookie) = value;
			}
		}

		// Token: 0x170098FF RID: 39167
		// (get) Token: 0x06028116 RID: 164118 RVA: 0x003CFE78 File Offset: 0x003CE078
		// (set) Token: 0x06028117 RID: 164119 RVA: 0x003CFE8C File Offset: 0x003CE08C
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x06028118 RID: 164120 RVA: 0x003CFEA1 File Offset: 0x003CE0A1
		public FWwiseExternalSourceCookedData()
		{
		}

		// Token: 0x06028119 RID: 164121 RVA: 0x003CFEA9 File Offset: 0x003CE0A9
		public FWwiseExternalSourceCookedData(int Cookie, FName DebugName)
		{
			this.Cookie = Cookie;
			this.DebugName = DebugName;
		}

		// Token: 0x0602811A RID: 164122 RVA: 0x003CFEBF File Offset: 0x003CE0BF
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseExternalSourceCookedData.StaticStruct();
		}

		// Token: 0x0602811B RID: 164123 RVA: 0x003CFECB File Offset: 0x003CE0CB
		[NullableContext(2)]
		public FWwiseExternalSourceCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602811C RID: 164124 RVA: 0x003CFED5 File Offset: 0x003CE0D5
		public FWwiseExternalSourceCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602811D RID: 164125 RVA: 0x003CFEE0 File Offset: 0x003CE0E0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseExternalSourceCookedData(Pointer, false, true);
		}

		// Token: 0x0602811E RID: 164126 RVA: 0x003CFEEA File Offset: 0x003CE0EA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseExternalSourceCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04015FDF RID: 90079
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseFileHandler.WwiseExternalSourceCookedData";

		// Token: 0x04015FE0 RID: 90080
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015FE1 RID: 90081
		internal static int __PropertyOffset_Cookie;

		// Token: 0x04015FE2 RID: 90082
		internal static int __PropertyOffset_DebugName;
	}
}
