using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000935 RID: 2357
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ClientEntityPackData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FClientEntityPackData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008530 RID: 34096 RVA: 0x000BDF46 File Offset: 0x000BC146
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClientEntityPackData._ScriptStructPtr != 0) ? FClientEntityPackData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ClientEntityPackData", ref FClientEntityPackData._ScriptStructPtr);
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06008531 RID: 34097 RVA: 0x000BDF6A File Offset: 0x000BC16A
		// (set) Token: 0x06008532 RID: 34098 RVA: 0x000BDF7A File Offset: 0x000BC17A
		public unsafe int PackId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClientEntityPackData.__PropertyOffset_PackId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClientEntityPackData.__PropertyOffset_PackId) = value;
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06008533 RID: 34099 RVA: 0x000BDF8C File Offset: 0x000BC18C
		// (set) Token: 0x06008534 RID: 34100 RVA: 0x000BDFCF File Offset: 0x000BC1CF
		public TArray<int> EntityIDs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._EntityIDs) == null)
				{
					result = (this._EntityIDs = new TArray<int>(base.NativePtr + (IntPtr)FClientEntityPackData.__PropertyOffset_EntityIDs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EntityIDs.CopyAssign(value);
			}
		}

		// Token: 0x06008535 RID: 34101 RVA: 0x000BDFDD File Offset: 0x000BC1DD
		public FClientEntityPackData()
		{
		}

		// Token: 0x06008536 RID: 34102 RVA: 0x000BDFE5 File Offset: 0x000BC1E5
		public FClientEntityPackData(int PackId, TArray<int> EntityIDs)
		{
			this.PackId = PackId;
			this.EntityIDs = EntityIDs;
		}

		// Token: 0x06008537 RID: 34103 RVA: 0x000BDFFB File Offset: 0x000BC1FB
		protected override IntPtr GetUStructPtr()
		{
			return FClientEntityPackData.StaticStruct();
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x000BE007 File Offset: 0x000BC207
		[NullableContext(2)]
		public FClientEntityPackData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008539 RID: 34105 RVA: 0x000BE011 File Offset: 0x000BC211
		public FClientEntityPackData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600853A RID: 34106 RVA: 0x000BE01C File Offset: 0x000BC21C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClientEntityPackData(Pointer, false, true);
		}

		// Token: 0x0600853B RID: 34107 RVA: 0x000BE026 File Offset: 0x000BC226
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClientEntityPackData(Pointer, MemoryOwner);
		}

		// Token: 0x04003F62 RID: 16226
		public const string __ObjectPath = "/Script/Engine.ClientEntityPackData";

		// Token: 0x04003F63 RID: 16227
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003F64 RID: 16228
		internal static int __PropertyOffset_PackId;

		// Token: 0x04003F65 RID: 16229
		internal static int __PropertyOffset_EntityIDs;

		// Token: 0x04003F66 RID: 16230
		[Nullable(2)]
		private TArray<int> _EntityIDs;
	}
}
