using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C22 RID: 3106
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HISMDistanceInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FHISMDistanceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009D6B RID: 40299 RVA: 0x000DFCE0 File Offset: 0x000DDEE0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHISMDistanceInfo._ScriptStructPtr != 0) ? FHISMDistanceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HISMDistanceInfo", ref FHISMDistanceInfo._ScriptStructPtr);
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x06009D6C RID: 40300 RVA: 0x000DFD04 File Offset: 0x000DDF04
		// (set) Token: 0x06009D6D RID: 40301 RVA: 0x000DFD18 File Offset: 0x000DDF18
		public unsafe string Index
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHISMDistanceInfo.__PropertyOffset_Index)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHISMDistanceInfo.__PropertyOffset_Index)), value);
			}
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x06009D6E RID: 40302 RVA: 0x000DFD2D File Offset: 0x000DDF2D
		// (set) Token: 0x06009D6F RID: 40303 RVA: 0x000DFD3D File Offset: 0x000DDF3D
		public unsafe float StartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHISMDistanceInfo.__PropertyOffset_StartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHISMDistanceInfo.__PropertyOffset_StartDistance) = value;
			}
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x06009D70 RID: 40304 RVA: 0x000DFD4E File Offset: 0x000DDF4E
		// (set) Token: 0x06009D71 RID: 40305 RVA: 0x000DFD5E File Offset: 0x000DDF5E
		public unsafe float EndDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHISMDistanceInfo.__PropertyOffset_EndDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHISMDistanceInfo.__PropertyOffset_EndDistance) = value;
			}
		}

		// Token: 0x06009D72 RID: 40306 RVA: 0x000DFD6F File Offset: 0x000DDF6F
		public FHISMDistanceInfo()
		{
		}

		// Token: 0x06009D73 RID: 40307 RVA: 0x000DFD77 File Offset: 0x000DDF77
		public FHISMDistanceInfo(string Index, float StartDistance, float EndDistance)
		{
			this.Index = Index;
			this.StartDistance = StartDistance;
			this.EndDistance = EndDistance;
		}

		// Token: 0x06009D74 RID: 40308 RVA: 0x000DFD94 File Offset: 0x000DDF94
		protected override IntPtr GetUStructPtr()
		{
			return FHISMDistanceInfo.StaticStruct();
		}

		// Token: 0x06009D75 RID: 40309 RVA: 0x000DFDA0 File Offset: 0x000DDFA0
		[NullableContext(2)]
		public FHISMDistanceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009D76 RID: 40310 RVA: 0x000DFDAA File Offset: 0x000DDFAA
		public FHISMDistanceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009D77 RID: 40311 RVA: 0x000DFDB5 File Offset: 0x000DDFB5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHISMDistanceInfo(Pointer, false, true);
		}

		// Token: 0x06009D78 RID: 40312 RVA: 0x000DFDBF File Offset: 0x000DDFBF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHISMDistanceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040056D8 RID: 22232
		public const string __ObjectPath = "/Script/Engine.HISMDistanceInfo";

		// Token: 0x040056D9 RID: 22233
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040056DA RID: 22234
		internal static int __PropertyOffset_Index;

		// Token: 0x040056DB RID: 22235
		internal static int __PropertyOffset_StartDistance;

		// Token: 0x040056DC RID: 22236
		internal static int __PropertyOffset_EndDistance;
	}
}
