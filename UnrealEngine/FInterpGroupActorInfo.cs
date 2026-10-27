using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C7F RID: 3199
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpGroupActorInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FInterpGroupActorInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A274 RID: 41588 RVA: 0x000E6B1D File Offset: 0x000E4D1D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpGroupActorInfo._ScriptStructPtr != 0) ? FInterpGroupActorInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InterpGroupActorInfo", ref FInterpGroupActorInfo._ScriptStructPtr);
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x0600A275 RID: 41589 RVA: 0x000E6B41 File Offset: 0x000E4D41
		// (set) Token: 0x0600A276 RID: 41590 RVA: 0x000E6B55 File Offset: 0x000E4D55
		public unsafe FName ObjectName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpGroupActorInfo.__PropertyOffset_ObjectName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpGroupActorInfo.__PropertyOffset_ObjectName) = value;
			}
		}

		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x0600A277 RID: 41591 RVA: 0x000E6B6C File Offset: 0x000E4D6C
		// (set) Token: 0x0600A278 RID: 41592 RVA: 0x000E6BAF File Offset: 0x000E4DAF
		public TArray<AActor> Actors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<AActor>(base.NativePtr + (IntPtr)FInterpGroupActorInfo.__PropertyOffset_Actors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x0600A279 RID: 41593 RVA: 0x000E6BBD File Offset: 0x000E4DBD
		public FInterpGroupActorInfo()
		{
		}

		// Token: 0x0600A27A RID: 41594 RVA: 0x000E6BC5 File Offset: 0x000E4DC5
		public FInterpGroupActorInfo(FName ObjectName, TArray<AActor> Actors)
		{
			this.ObjectName = ObjectName;
			this.Actors = Actors;
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x000E6BDB File Offset: 0x000E4DDB
		protected override IntPtr GetUStructPtr()
		{
			return FInterpGroupActorInfo.StaticStruct();
		}

		// Token: 0x0600A27C RID: 41596 RVA: 0x000E6BE7 File Offset: 0x000E4DE7
		[NullableContext(2)]
		public FInterpGroupActorInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A27D RID: 41597 RVA: 0x000E6BF1 File Offset: 0x000E4DF1
		public FInterpGroupActorInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x000E6BFC File Offset: 0x000E4DFC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpGroupActorInfo(Pointer, false, true);
		}

		// Token: 0x0600A27F RID: 41599 RVA: 0x000E6C06 File Offset: 0x000E4E06
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpGroupActorInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04005929 RID: 22825
		public const string __ObjectPath = "/Script/Engine.InterpGroupActorInfo";

		// Token: 0x0400592A RID: 22826
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400592B RID: 22827
		internal static int __PropertyOffset_ObjectName;

		// Token: 0x0400592C RID: 22828
		internal static int __PropertyOffset_Actors;

		// Token: 0x0400592D RID: 22829
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actors;
	}
}
