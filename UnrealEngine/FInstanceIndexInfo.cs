using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C67 RID: 3175
	[UnrealObjectPath("/Script/Engine.InstanceIndexInfo")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FInstanceIndexInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A17F RID: 41343 RVA: 0x000E56EB File Offset: 0x000E38EB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInstanceIndexInfo._ScriptStructPtr != 0) ? FInstanceIndexInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InstanceIndexInfo", ref FInstanceIndexInfo._ScriptStructPtr);
		}

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x0600A180 RID: 41344 RVA: 0x000E570F File Offset: 0x000E390F
		// (set) Token: 0x0600A181 RID: 41345 RVA: 0x000E571F File Offset: 0x000E391F
		public unsafe int GroupIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceIndexInfo.__PropertyOffset_GroupIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceIndexInfo.__PropertyOffset_GroupIndex) = value;
			}
		}

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x0600A182 RID: 41346 RVA: 0x000E5730 File Offset: 0x000E3930
		// (set) Token: 0x0600A183 RID: 41347 RVA: 0x000E5740 File Offset: 0x000E3940
		public unsafe int SubInstanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceIndexInfo.__PropertyOffset_SubInstanceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceIndexInfo.__PropertyOffset_SubInstanceIndex) = value;
			}
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x000E5751 File Offset: 0x000E3951
		public FInstanceIndexInfo()
		{
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x000E5759 File Offset: 0x000E3959
		public FInstanceIndexInfo(int GroupIndex, int SubInstanceIndex)
		{
			this.GroupIndex = GroupIndex;
			this.SubInstanceIndex = SubInstanceIndex;
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x000E576F File Offset: 0x000E396F
		protected override IntPtr GetUStructPtr()
		{
			return FInstanceIndexInfo.StaticStruct();
		}

		// Token: 0x0600A187 RID: 41351 RVA: 0x000E577B File Offset: 0x000E397B
		[NullableContext(2)]
		public FInstanceIndexInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A188 RID: 41352 RVA: 0x000E5785 File Offset: 0x000E3985
		public FInstanceIndexInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A189 RID: 41353 RVA: 0x000E5790 File Offset: 0x000E3990
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInstanceIndexInfo(Pointer, false, true);
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x000E579A File Offset: 0x000E399A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInstanceIndexInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040058B3 RID: 22707
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InstanceIndexInfo";

		// Token: 0x040058B4 RID: 22708
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058B5 RID: 22709
		internal static int __PropertyOffset_GroupIndex;

		// Token: 0x040058B6 RID: 22710
		internal static int __PropertyOffset_SubInstanceIndex;
	}
}
